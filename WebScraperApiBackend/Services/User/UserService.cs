using WebScraperApiBackend.DataAcces;

namespace WebScraperApiBackend.Services.User
{
    public class UserService : IUserService
    {
        private readonly ScraperDBContext _context;

        public UserService(ScraperDBContext context)
        {
            _context = context;
        }

        public bool CheckIfEmailExists(string Email)
        {
            throw new NotImplementedException();
        }

        public bool CheckIfUserNameExists(string UserName)
        {
            throw new NotImplementedException();
        }
    }
}
