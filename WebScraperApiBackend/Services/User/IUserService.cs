namespace WebScraperApiBackend.Services.User
{
    public interface IUserService
    {
        bool CheckIfUserNameExists(string UserName);
        bool CheckIfEmailExists(string Email);
    }
}
