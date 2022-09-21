using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace WebScraperApiBackend.Models.DataModels
{
    public class User : BaseEntity
    {

        [Required, StringLength(20)]
        public string UserName { get; set; } = string.Empty;

        [Required, StringLength(30)]
        public string Name { get; set; } = string.Empty;

        [Required, StringLength(50)]
        public string LastName { get; set; } = string.Empty;

        [Required, PasswordPropertyText]
        public string Password { get; set; } = string.Empty;

    }
}
