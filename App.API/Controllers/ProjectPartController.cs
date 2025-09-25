using App.Application;
using Microsoft.AspNetCore.Mvc;

namespace Scriptat.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ProjectPartController : ControllerBase
    {
        [HttpPost]
        [Route("AddNewProjectPart")]
        public ActionResult AddNewProjectPart()
        {
            var result = new ApiResult
            {
                success = true,
                errorList = new List<ApiError>(),
                data = new { }
            };
            return Ok(result);
        }

        [HttpPut]
        [Route("UpdateProjectPart")]
        public ActionResult UpdateProjectPart()
        {
            var result = new ApiResult
            {
                success = true,
                errorList = new List<ApiError>(),
                data = new { }
            };
            return Ok(result);
        }

        [HttpPut]
        [Route("DeleteProjectPart/{id}")]
        public ActionResult DeleteProjectPart(int id)
        {
            var result = new ApiResult
            {
                success = true,
                errorList = new List<ApiError>(),
                data = new { }
            };
            return Ok(result);
        }

        [HttpGet]
        [Route("GetProjectDetailCardVeiw/{id}")]
        public ActionResult GetProjectDetailCardVeiw(int id)
        {
            var result = new ApiResult
            {
                success = true,
                errorList = new List<ApiError>(),
                data = new { }
            };
            return Ok(result);
        }

        [HttpGet]
        [Route("GetProjectDetailDataVeiw/{id}")]
        public ActionResult GetProjectDetailDataVeiw(int id)
        {
            var result = new ApiResult
            {
                success = true,
                errorList = new List<ApiError>(),
                data = new { }
            };
            return Ok(result);
        }

        [HttpGet]
        [Route("GetComponentList/{id}")]
        public ActionResult GetComponentList(int id)
        {
            var result = new ApiResult
            {
                success = true,
                errorList = new List<ApiError>(),
                data = new { }
            };
            return Ok(result);
        }

        [HttpGet]
        [Route("GetCharacterLocationComponentList/{id}")]
        public ActionResult GetCharacterLocationComponentList(int id)
        {
            var result = new ApiResult
            {
                success = true,
                errorList = new List<ApiError>(),
                data = new { }
            };
            return Ok(result);
        }

        [HttpGet]
        [Route("GetProjectDetailCardVeiwByProjectPart/{projectpartid}")]
        public ActionResult GetProjectDetailCardVeiwByProjectPart(int projectpartid)
        {
            var result = new ApiResult
            {
                success = true,
                errorList = new List<ApiError>(),
                data = new { }
            };
            return Ok(result);
        }
    }
}


