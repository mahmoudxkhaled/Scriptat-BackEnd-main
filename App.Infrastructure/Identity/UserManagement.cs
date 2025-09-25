using App.Domain;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using System.Security.Claims;

namespace App.Infrastructure
{
    public class UserManagement : IUserManagement
    {
        private static string Secret = "ERMN05OPLoDvbTTa/QkqLNMI7cPLguaRyHzyg7n5qNBVjQmtBhz4SzYh4NBVCXi3KJHlSXKP+oi2+bXr6CUYTR==";
        private readonly IHttpContextAccessor _contextAccessor;
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly SignInManager<ApplicationUser> _signInManager;
        private readonly UserTokenService _tokenService;
        public UserManagement(UserManager<ApplicationUser> userManager, SignInManager<ApplicationUser> signInManager, UserTokenService tokenService, IHttpContextAccessor contextAccessor)
        {
            _userManager = userManager;
            _signInManager = signInManager;
            _tokenService = tokenService;
            _contextAccessor = contextAccessor;
        }

        public async Task<ApiResult> Login(LoginDto loginDto)
        {
            ApiError _error;
            ApiResult _result = new ApiResult();
            List<ApiError> _errorList = new List<ApiError>();
            _result.success = false;

            var user = await _userManager.FindByNameAsync(loginDto.UserName);
            if (user == null)
            {
                _error = new ApiError();
                _error.message = "Invalid UserName";
                _errorList.Add(_error);
            }
            else if (!user.EmailConfirmed)
            {
                _error = new ApiError();
                _error.message = "Email is not confirmed";
                _errorList.Add(_error);
            }
            else if (!user.PhoneNumberConfirmed)
            {
                _error = new ApiError();
                _error.message = "Phone number is not confirmed";
                _errorList.Add(_error);
            }
            else
            {
                var _loginresult = await _signInManager.CheckPasswordSignInAsync(user, loginDto.Password, false);

                if (_loginresult.Succeeded)
                {
                    UserDto _user = CreateUserObject(user);
                    await SetUserToken(user, _user.TokenKey);

                    _result.success = true;
                    _result.data = (object)new
                    {
                        UserName = _user.UserName,
                        UserProfileName = _user.UserFullName,
                        profilepictureUrl = (!_errorList.Any<ApiError>() ? "https://scriptat.org/images/icons/User.png" : (!System.String.IsNullOrEmpty(_user.UserImageUrl) ? _user.UserImageUrl : "")),
                        LoginToken = _user.TokenKey
                    };
                }
                else
                {
                    _error = new ApiError();
                    _error.message = "Invalid Password";
                    _errorList.Add(_error);
                }
            }
            _result.errorList = _errorList;
            return _result;
        }

        public async Task<ApiResult> Register(RegisterDto registerDto)
        {
            ApiError _error;
            ApiResult _result = new ApiResult();
            List<ApiError> _errorList = new List<ApiError>();
            _result.success = false;

            if (await _userManager.Users.AnyAsync(x => x.UserName == registerDto.UserName))
            {
                _error = new ApiError();
                _error.message = "User name has been taken";
                _errorList.Add(_error);
            }
            else
            {
                var user = new ApplicationUser
                {
                    UserName = registerDto.UserName,
                    UserJobTitle = registerDto.UserJobTitle,
                    UserFullName = registerDto.UserFullName,
                    Email = registerDto.Email,
                    PhoneNumber = registerDto.Phone,
                    EmailConfirmed = true,
                    PhoneNumberConfirmed = true
                };

                var result = await _userManager.CreateAsync(user, registerDto.Password);

                if (result.Succeeded)
                {

                    _result.success = true;
                    _result.data = CreateUserObject(user);
                }
                else
                {
                    _error = new ApiError();
                    _error.message = "Problem registering user";
                    _errorList.Add(_error);
                }

                //var origin = Request.Headers["origin"];
                //var token = await _userManager.GenerateEmailConfirmationTokenAsync(user);
                //token = WebEncoders.Base64UrlEncode(Encoding.UTF8.GetBytes(token));

                //var verifyUrl = $"{origin}/account/verifyEmail?token={token}&email={user.Email}";
                //var message = $"<p>Please click the below link to verify your email address:</p><p><a href='{verifyUrl}'>Click to verify email</a></p>";

                //await _emailSender.SendEmailAsync(user.Email, "Please verify email", message);

                //return Ok("Registration success - please verify email");
                // Ok("Registration success");
            }
            return _result;
        }

        public async Task<UserDto> GetCurrentUser()
        {
            var user = await _userManager.Users.FirstOrDefaultAsync(x => x.UserName == _contextAccessor.HttpContext.User.FindFirstValue(ClaimTypes.Name));
            await SetUserToken(user, "");
            return CreateUserObject(user);
        }
        public UserDto CreateUserObject(ApplicationUser user)
        {
            var TS = _tokenService.GenerateToken(user);
            return new UserDto
            {
                UserId = user.Id,
                UserName = user.UserName,
                UserFullName = user.UserFullName,
                UserImageUrl = user.UserImageUrl,
                UserPhoneNumber = user.PhoneNumber,
                UserEmailAddress = user.Email,
                TokenKey = TS
            };
        }
        public async Task<ApiResult> UserToken()
        {
            ApiError _error;
            ApiResult _result = new ApiResult();
            List<ApiError> _errorList = new List<ApiError>();
            _result.success = false;

            var UserToken = _contextAccessor.HttpContext.Request.Cookies["UserToken"];
            var user = await _userManager.Users.Include(r => r.AspNetUserDevices).FirstOrDefaultAsync(x => x.UserName == _contextAccessor.HttpContext.User.FindFirstValue(ClaimTypes.Name));


            if (user == null)
            {
                _error = new ApiError();
                _error.message = "Unauthorized User";
                _errorList.Add(_error);
            }
            else
            {
                var oldToken = user.AspNetUserDevices.SingleOrDefault(x => x.TokenKey == UserToken);
                if (oldToken != null && !oldToken.IsActive)
                {
                    _error = new ApiError();
                    _error.message = "Unauthorized User";
                    _errorList.Add(_error);
                }
            }

            _result.success = true;
            _result.data = CreateUserObject(user);

            return _result;
        }

        public async Task SetUserToken(ApplicationUser user, string token)
        {
            //var _userToken = _tokenService.GenerateUserToken();
            AspNetUserDevices _userToken = new AspNetUserDevices() { TokenKey = token };
            user.AspNetUserDevices.Add(_userToken);
            await _userManager.UpdateAsync(user);

            var cookieOptions = new CookieOptions
            {
                HttpOnly = true,
                Expires = DateTime.UtcNow.AddDays(7)
            };

            _contextAccessor.HttpContext.Response.Cookies.Append("UserToken", _userToken.TokenKey, cookieOptions);
        }

        public IEnumerable<IdentityUser> GetAllUsers()
        {
            throw new NotImplementedException();
        }

        public Task<SignInResult> UserLogin(LoginDto Input)
        {
            throw new NotImplementedException();
        }

        public Task<IdentityUser> GetUserByName(LoginDto Input)
        {
            throw new NotImplementedException();
        }

        public ClaimsPrincipal GetPrincipal(string token)
        {
            throw new NotImplementedException();
        }

        public string GenerateToken(string UserId)
        {
            throw new NotImplementedException();
        }

        public string ValidateToken(string token)
        {
            return _tokenService.ValidateToken(token);
        }

        public bool IsValid(HttpRequestMessage request)
        {
            return _tokenService.IsValid(request);
        }

        public string GetUserId(HttpContext request)
        {
            return _tokenService.GetUserId(request);
        }
    }
}
