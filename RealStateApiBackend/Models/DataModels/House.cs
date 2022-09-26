<<<<<<< HEAD
﻿using System.ComponentModel.DataAnnotations;

namespace RealStateApiBackend.Models.DataModels
=======
﻿namespace RealStateApiBackend.Models.DataModels
>>>>>>> 04dd3f060b6961622b916f6434925dd7daa95225
{
    public enum Type
    {
        Rent,
        Sell,
        Temporary
    }

    public class House
    {
<<<<<<< HEAD
        [Required]
        [Key]
        public int Id { get; set; }
        public string Title { get; set; } = string.Empty;
        public DateTime PublishDate { get; set; } = DateTime.Now;
=======
        public string Title { get; set; } = string.Empty;
        public string PublishDate { get; set; } = string.Empty;
>>>>>>> 04dd3f060b6961622b916f6434925dd7daa95225
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
<<<<<<< HEAD
=======

    // TODO: House search service on Scraper API. Look for Scraper API and implement
>>>>>>> 04dd3f060b6961622b916f6434925dd7daa95225
}