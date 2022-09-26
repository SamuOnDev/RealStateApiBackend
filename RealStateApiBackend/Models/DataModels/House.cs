using System.ComponentModel.DataAnnotations;

namespace RealStateApiBackend.Models.DataModels
{
    public enum Type
    {
        Rent,
        Sell,
        Temporary
    }

    public class House
    {
        [Required]
        [Key]
        public int Id { get; set; }
        public string Title { get; set; } = string.Empty;
        public DateTime PublishDate { get; set; } = DateTime.Now;
        public string ContactEmail { get; set; } = string.Empty;
        public int Price { get; set; }
        public string Address { get; set; } = string.Empty;
        public int PhoneNumber { get; set; }
        public string Street { get; set; } = string.Empty;
        public string City { get; set; } = string.Empty;
        public int Size { get; set; }
        public int Rooms { get; set; }
        public int Bathroom { get; set; }
        public int ParkingCapacity { get; set; }
        public Type Type { get; set; } = Type.Rent;
    }
}