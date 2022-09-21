using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using WebScraperApiBackend.DataAcces;
using WebScraperApiBackend.Helpers;
using WebScraperApiBackend.Models.DataModels;

namespace WebScraperApiBackend.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class AccountController : ControllerBase
    {
        private readonly JwtSettings _jwtSettings;
        private readonly ScraperDBContext _context;

        public AccountController(JwtSettings jwtSettings, ScraperDBContext context)
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
                        UserName = searchUser.Name,
                        EmailId = searchUser.Email,
                        Id = searchUser.Id,
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
