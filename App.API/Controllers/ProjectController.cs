
using App.Application;
using App.Infrastructure;
using Microsoft.AspNetCore.Mvc;
using Scriptat.API.Helper;

namespace Scriptat.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ProjectController : ControllerBase
    {
        private readonly ICoreHelper ICoreHelper;
        private readonly IUserManagement _userManagement;
        private readonly ILogger<ProjectController> Ilogger;
        private readonly IProjectRepository IProjectRepository;

        public ProjectController(
          IProjectRepository _IProjectRepository,
          IUserManagement UserManagement,
          ILogger<ProjectController> _Ilogger,
          ICoreHelper _ICoreHelper)
        {
            this.ICoreHelper = _ICoreHelper;
            this._userManagement = UserManagement;
            this.IProjectRepository = _IProjectRepository;
            this.Ilogger = _Ilogger;
        }

        [HttpGet]
        [Route("GetProjectList")]
        public async Task<ActionResult> GetProjectList()
        {
            ProjectController projectController = this;
            List<ApiError> errorList = new List<ApiError>();
            //UserDto _user = await projectController.IUserManagement.GetCurrentUser();

            string userId = _userManagement.GetUserId(HttpContext);
            //string userId = _user.UserId;
            List<VM_ProjectCard> projectList1 = await projectController.IProjectRepository.GetProjectList(userId);
            ApiResult apiResult = new ApiResult()
            {
                success = !errorList.Any<ApiError>(),
                errorList = errorList,
                data = (object)new { Projects = projectList1 }
            };
            ActionResult projectList2 = (ActionResult)projectController.Ok((object)apiResult);
            errorList = (List<ApiError>)null;
            return projectList2;
        }

        [HttpPost]
        [Route("AddNewProject")]
        public async Task<ActionResult> AddNewProject(List<IFormFile> formFiles)
        {
            ProjectController projectController = this;
            string empty = string.Empty;
            VM_ProjectNew _projectvm = new VM_ProjectNew();
            HttpRequest request = projectController.HttpContext.Request;
            string _userid = _userManagement.GetUserId(projectController.HttpContext);
            _projectvm.UserId = _userid;
            _projectvm.ProjectTypeId = !string.IsNullOrEmpty((string)request.Form["ProjectTypeId"]) ? Convert.ToInt32((string)request.Form["ProjectTypeId"]) : 1;
            _projectvm.ProjectPartCount = !string.IsNullOrEmpty((string)request.Form["ProjectPartCount"]) ? Convert.ToInt32((string)request.Form["ProjectPartCount"]) : 1;
            _projectvm.ProjectTitle = !string.IsNullOrEmpty((string)request.Form["ProjectTitle"]) ? (string)request.Form["ProjectTitle"] : string.Empty;
            _projectvm.ProjectDescription = !string.IsNullOrEmpty((string)request.Form["ProjectDescription"]) ? (string)request.Form["ProjectDescription"] : string.Empty;
            _projectvm.ScriptTypeId = !string.IsNullOrEmpty((string)request.Form["ScriptTypeId"]) ? Convert.ToInt32((string)request.Form["ScriptTypeId"]) : 1;
            _projectvm.ProjectPartTitle = !string.IsNullOrEmpty((string)request.Form["ProjectPartTitle"]) ? (string)request.Form["ProjectPartTitle"] : string.Empty;
            VM_ProjectFile vmProjectFile = await ApiHelper.UploadProjectFiles(request, _projectvm.ProjectTitle);
            _projectvm.ProjectPartFileUrl = vmProjectFile.ProjectFileUrl;
            _projectvm.ProjectCode = vmProjectFile.ProjectCode;
            bool flag = await projectController.IProjectRepository.SaveProject(_projectvm);
            List<ApiError> apiErrorList = new List<ApiError>();
            ApiResult _result = new ApiResult();
            _result.success = flag;
            _result.errorList = apiErrorList;
            if (flag)
                _result.data = (object)new
                {
                    Projects = await projectController.IProjectRepository.GetProjectList(_userid)
                };
            ActionResult actionResult = (ActionResult)projectController.Ok((object)_result);
            _projectvm = (VM_ProjectNew)null;
            _userid = (string)null;
            _result = (ApiResult)null;
            return actionResult;
        }

        [HttpPut]
        [Route("UpdateProject")]
        public async Task<ActionResult> UpdateProject(List<IFormFile> formFiles)
        {
            ProjectController projectController = this;
            string empty = string.Empty;
            HttpRequest requestdata = projectController.HttpContext.Request;
            VM_ProjectUpdate _projectvm = new VM_ProjectUpdate();
            _projectvm.ProjectId = !string.IsNullOrEmpty((string)requestdata.Form["ProjectId"]) ? Convert.ToInt32((string)requestdata.Form["ProjectId"]) : 1;
            _projectvm.ProjectTypeId = !string.IsNullOrEmpty((string)requestdata.Form["ProjectTypeId"]) ? Convert.ToInt32((string)requestdata.Form["ProjectTypeId"]) : 1;
            _projectvm.ProjectPartCount = !string.IsNullOrEmpty((string)requestdata.Form["ProjectPartCount"]) ? Convert.ToInt32((string)requestdata.Form["ProjectPartCount"]) : 1;
            _projectvm.ProjectTitle = !string.IsNullOrEmpty((string)requestdata.Form["ProjectTitle"]) ? (string)requestdata.Form["ProjectTitle"] : string.Empty;
            _projectvm.ProjectDescription = !string.IsNullOrEmpty((string)requestdata.Form["ProjectDescription"]) ? (string)requestdata.Form["ProjectDescription"] : string.Empty;
            _projectvm.ProjectSummary = !string.IsNullOrEmpty((string)requestdata.Form["ProjectSummary"]) ? (string)requestdata.Form["ProjectSummary"] : string.Empty;

            _projectvm.ProjectSummaryFileUrl = await ApiHelper.UploadProjectFiles(requestdata, await projectController.ICoreHelper.GetProjectCode(_projectvm.ProjectId), _projectvm.ProjectTitle);
            bool flag = await projectController.IProjectRepository.UpdateProject(_projectvm);
            List<ApiError> apiErrorList = new List<ApiError>();
            ApiResult apiResult = new ApiResult();
            apiResult.success = flag;
            apiResult.errorList = apiErrorList;
            if (flag)
                apiResult.data = (object)new
                {
                    UpdatedProject = _projectvm
                };
            ActionResult actionResult = (ActionResult)projectController.Ok((object)apiResult);
            requestdata = (HttpRequest)null;
            _projectvm = (VM_ProjectUpdate)null;
            //apiHelper = (ApiHelper)null;
            return actionResult;
        }

        [HttpPut]
        [Route("DeleteProject/{id}")]
        public async Task<ActionResult> DeleteProject(int id)
        {
            ProjectController projectController = this;
            string empty = string.Empty;
            HttpRequest request = projectController.HttpContext.Request;
            string _userid = _userManagement.GetUserId(projectController.HttpContext);
            bool flag = await projectController.IProjectRepository.DeleteProject(id, _userid);
            List<ApiError> apiErrorList = new List<ApiError>();
            ApiResult _result = new ApiResult();
            _result.success = flag;
            _result.errorList = apiErrorList;
            if (flag)
                _result.data = (object)new
                {
                    Projects = await projectController.IProjectRepository.GetProjectList(_userid)
                };
            ActionResult actionResult = (ActionResult)projectController.Ok((object)_result);
            _userid = (string)null;
            _result = (ApiResult)null;
            return actionResult;
        }

        [HttpGet]
        [Route("GetScriptTypeInstruction")]
        public async Task<ActionResult> GetScriptTypeInstruction()
        {
            ProjectController projectController = this;
            List<ApiError> errorList = new List<ApiError>();
            HttpRequest request = projectController.HttpContext.Request;
            List<VM_ScriptTypeInstruction> scriptTypeInstructionList;
            if (_userManagement.GetUserId(projectController.HttpContext) == null)
            {
                errorList.Add(new ApiError()
                {
                    Input = "",
                    Message = "Unauthorized Request !"
                });
                scriptTypeInstructionList = new List<VM_ScriptTypeInstruction>();
            }
            else
                scriptTypeInstructionList = (await projectController.IProjectRepository.GetScriptTypeList()).Select<App.Domain.ScriptType, VM_ScriptTypeInstruction>((Func<App.Domain.ScriptType, VM_ScriptTypeInstruction>)(x => new VM_ScriptTypeInstruction()
                {
                    ScriptTypeId = x.Id,
                    ScriptTypeName = x.Title,
                    InstructionImageUrl = x.InstructionImageUrl,
                    ScriptTypeInstructionHtml = x.Instruction
                })).ToList<VM_ScriptTypeInstruction>();
            ApiResult apiResult = new ApiResult()
            {
                success = !errorList.Any<ApiError>(),
                errorList = errorList,
                data = (object)new
                {
                    ScriptTypeList = scriptTypeInstructionList
                }
            };
            ActionResult scriptTypeInstruction = (ActionResult)projectController.Ok((object)apiResult);
            errorList = (List<ApiError>)null;
            return scriptTypeInstruction;
        }
    }
}
