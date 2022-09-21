using System.ComponentModel.DataAnnotations;

namespace WebScraperApiBackend.Models.DataModels
{
    public class SearchHouse
    {
        [Required]
        [Key]
        public int Id { get; set; }

        public int PriceMin { get; set; }
        public int PriceMax { get; set; }
        public string City { get; set; } = string.Empty;
        public int Rooms { get; set; }
        public int Size { get; set; }
        public Type Type { get; set; } = Type.Rent;
        public bool IsFavorite { get; set; } = false;
    }
}
