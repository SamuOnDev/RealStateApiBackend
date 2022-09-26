using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace RealStateApiBackend.Models.DataModels
{
    public class SearchHouse
    {
        public int? MinPrice { get; set; }
        public int? MaxPrice { get; set; }
        public string Street { get; set; } = string.Empty;
        public string City { get; set; } = string.Empty;
        public int MinSize { get; set; } = 0;
        public int MaxSize { get; set; } = int.MaxValue;
        public int Rooms { get; set; } = int.MaxValue;
        public int Bathroom { get; set; } = int.MaxValue;
        public int ParkingCapacity { get; set; } = int.MaxValue;
        public Type Type { get; set; } = Type.Rent;
    }
}