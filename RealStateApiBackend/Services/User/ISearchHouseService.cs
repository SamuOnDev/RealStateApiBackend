using RealStateApiBackend.Models.DataModels;

namespace RealStateApiBackend.Services.User
{
    public interface ISearchHouseService
    {
        Task<House?> GetHouseAsync(SearchHouse Search);
        //Task<House> SearchHouseByPriceAsync(int MinPrice, int MaxPrice);
        //Task<House> SearchHouseByCity(string City);
        //Task<House> SearchHouseBySize(int MinSize, int MaxSize);
        //Task<House> SearchHouseByNumberOfRooms(int Rooms);
      
    }
}
