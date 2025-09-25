using App.Application;
using Microsoft.AspNetCore.Mvc;

namespace Scriptat.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ComponentController : ControllerBase
    {
        [HttpPost]
        [Route("AddElementImage")]
        public ActionResult AddElementImage()
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
        [Route("GetComponentDropDownList/{projectid}")]
        public ActionResult GetComponentDropDownList(int projectid)
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
        [Route("GetComponentLinkedDropDownList/{projectid}/{sceneid}/{componentid}")]
        public ActionResult GetComponentLinkedDropDownList(int projectid, int sceneid, int componentid)
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
        [Route("GetComponentList/{projectid}")]
        public ActionResult GetComponentList(int projectid)
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
        [Route("GetComponentElementList/{projectid}/{componentid}")]
        public ActionResult GetComponentElementList(int projectid, int componentid)
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


