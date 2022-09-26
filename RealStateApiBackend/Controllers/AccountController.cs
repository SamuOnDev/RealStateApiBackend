using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using RealStateApiBackend.DataAcces;
using RealStateApiBackend.Helpers;
using RealStateApiBackend.Models.DataModels;

namespace RealStateApiBackend.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class AccountController : ControllerBase
    {
        private readonly JwtSettings _jwtSettings;
        private readonly RealStateDBContext _context;

        public AccountController(JwtSettings jwtSettings, RealStateDBContext context)
        {
            _jwtSettings = jwtSettings;
            _context = context;
        }

        [HttpPost]
        public IActionResult GetToken(UserLogin userLogin)
        {
            try
            {
                var Token = new UserToken();

                var searchUser = (from user in _context.Users
                                  where user.Email == userLogin.UserEmail && user.Password == userLogin.Password
                                  select user).FirstOrDefault(); 

                if (searchUser != null)
                {
                    Token = JwtHelpers.GenTokenKey(new UserToken()
                    {
                        UserName = searchUser.UserName,
                        EmailId = searchUser.Email,
                        Id = searchUser.Id,
                        UserRole = searchUser.UserRole,
                        GuidId = Guid.NewGuid(),
                    }, _jwtSettings);
                }
                else
                {
                    return BadRequest("Wrong Credentials");
                }

                return Ok(Token);

            }
            catch (Exception ex)
            {
                throw new Exception("GetToken Error", ex);
            }
        }

        [HttpGet]
        [Authorize(AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme, Roles = "Administrator")]
        public IActionResult GetUserList()
        {
            var searchAllUsers = from user in _context.Users select user;

            return Ok(searchAllUsers);
        }
    }
}
