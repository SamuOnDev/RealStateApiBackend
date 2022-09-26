using System.ComponentModel.DataAnnotations;

namespace RealStateApiBackend.Models.DataModels
{
    public class UserLogin
    {
        [Required]
        public string UserEmail { get; set; }

        [Required]
        public string Password { get; set; }
    }
}
