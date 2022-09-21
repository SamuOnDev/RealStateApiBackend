using System.ComponentModel.DataAnnotations;

namespace WebScraperApiBackend.Models.DataModels
{
    public class UserLogin
    {
        [Required]
        public string UserEmail { get; set; }

        [Required]
        public string Password { get; set; }
    }
}
