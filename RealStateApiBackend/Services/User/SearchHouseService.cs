using Microsoft.AspNetCore.Mvc;
using RealStateApiBackend.DataAcces;
using RealStateApiBackend.Models.DataModels;

namespace RealStateApiBackend.Services.User
{
    public class SearchHouseService : ISearchHouseService
    {
        private readonly RealStateDBContext _context;

        SearchHouseService(RealStateDBContext context)
        {
            _context = context;
        }

        public Task<House?> GetHouseAsync(SearchHouse Search)
        {
            House? HouseList = null;

            // Search By Price
            if (Search.MinPrice != null || Search.MaxPrice != null)
            {
                if (Search.MinPrice == null)
                {
                    Search.MinPrice = 0;
                }

                if (Search.MaxPrice == null)
                {
                    Search.MaxPrice = int.MaxValue;
                }

                var HouseListByPrice = SearchHouseByPrice(Search.MinPrice, Search.MaxPrice);
            }

            // Search By City
            if (Search.City != string.Empty)
            {
                var HouseListByCity = SearchHouseByCity(Search.City);
            }

            // TODO: Continue with the logic for search a house

            // Return Logic

            return Task.FromResult(HouseList);
        }

        public House SearchHouseByPrice(int? MinPrice, int? MaxPrice)
        {
            var ListByPrice = (House)(from House in _context.Houses
                                    where House.Price > MinPrice && House.Price <= MaxPrice
                                    select House);

            return ListByPrice;
        }

        public House SearchHouseByCity(string City)
        {
            var ListByCity = (House)(from house in _context.Houses
                                    where house.City == City
                                    select house);
            
            return ListByCity;
        }

        public Task<House> SearchHouseByNumberOfRooms(int Rooms)
        {
            throw new NotImplementedException();
        }

        public Task<House> SearchHouseBySize(int MinSize, int MaxSize)
        {
            throw new NotImplementedException();
        }
    }
}
