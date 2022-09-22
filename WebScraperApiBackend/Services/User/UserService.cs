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

        public bool CheckIfUserNameExist(string UserName)
        {

            var IsThereAnUserName = (from user in _context.Users
                                  where user.UserName.Equals(UserName)
                                  select user).FirstOrDefault();

            if (IsThereAnUserName == null)
            {
                return false;
            }

            return true;
        }

        public bool CheckIfEmailExist(string Email)
        {
            var IsThereAnEmail = (from user in _context.Users
                                  where user.Email.Equals(Email)
                                  select user).FirstOrDefault();

            if (IsThereAnEmail == null)
            {
                return false;
            }

            return true;
        }
    }
}
