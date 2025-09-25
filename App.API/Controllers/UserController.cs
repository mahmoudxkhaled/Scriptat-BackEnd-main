using App.Domain;
using App.Infrastructure;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Scriptat.API.Helper;

namespace Scriptat.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IUserManagement _usermanager;
        private readonly UserTokenService _tokenService;

        public UserController(IUserManagement usermanager, UserTokenService tokenService)
        {
            _usermanager = usermanager;
            _tokenService = tokenService;
        }

        [AllowAnonymous]
        [HttpPost("login")]
        public async Task<ActionResult<ApiResult>> Login(LoginDto loginDto)
        {
            return await _usermanager.Login(loginDto);
        }
        [AllowAnonymous]
        [HttpPost("register")]
        public async Task<ActionResult<ApiResult>> Register()
        {
            var requestdata = HttpContext.Request;
            string imagePath = await ApiHelper.UploadUserImage(requestdata);
            RegisterDto registerDto = new RegisterDto()
            {
                UserName = requestdata.Form["UserName"],
                Email = requestdata.Form["Email"],
                Password = requestdata.Form["Email"],
                UserFullName = requestdata.Form["Email"],
                Phone = requestdata.Form["Email"],
                ImageUrl = imagePath

            };

            ApiResult returnResult = await _usermanager.Register(registerDto);
            return Ok(returnResult);
        }


        //[AllowAnonymous]
        //[HttpPost("login")]
        //public async Task<ActionResult<Dto_User>> Login(Dto_Login loginDto)
        //{
        //	ApiResult _result = new ApiResult();
        //          List<ApiError> _errorList = new List<ApiError>();

        //          ReturnResult returnResult = await _usermanager.Login(loginDto);
        //	if (returnResult.HasError)
        //	{
        //		return Unauthorized(returnResult.ErrorMessage);
        //	}
        //	else
        //	{
        //		return returnResult.UserObject;
        //	}
        //}

        //      [AllowAnonymous]
        //      [HttpPost("newlogin")]
        //      public async Task<ActionResult<Dto_User>> newlogin(Dto_Login loginDto)
        //      {
        //          ReturnResult returnResult = await _usermanager.Login(loginDto);
        //          if (returnResult.HasError)
        //          {
        //              return Unauthorized(returnResult.ErrorMessage);
        //          }
        //          else
        //          {
        //              return returnResult.UserObject;
        //          }
        //      //      }
        //[UnAuthorize]
        //[HttpGet]
        //public async Task<ActionResult<UserDto>> GetCurrentUser()
        //{
        //	return await _usermanager.GetCurrentUser();
        //}

        //[Authorize]
        //[HttpPost("UserToken")]
        //public async Task<ActionResult<UserDto>> UserToken()
        //{
        //	return Ok(await _usermanager.UserToken());
        //}
    }
}
