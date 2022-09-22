namespace WebScraperApiBackend.DTO
{
    public class UserDataDTO
    {
        // TODO: Complete DTO and make only administrator can see everything and users only some part. To prevent Future Problems
        public string UserName { get; set; } = string.Empty;
        public string FullName { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
    }
}
