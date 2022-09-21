namespace WebScraperApiBackend.Models.DataModels
{
    public enum Type
    {
        Rent,
        Sell,
        Temporary
    }

    public class House
    {
        public string Title { get; set; } = string.Empty;
        public int Price { get; set; }
        public string Address { get; set; } = string.Empty;
        public string City { get; set; } = string.Empty;
        public int Rooms { get; set; }
        public int Size { get; set; }
        public Type Type { get; set; } = Type.Rent;

    }
}
