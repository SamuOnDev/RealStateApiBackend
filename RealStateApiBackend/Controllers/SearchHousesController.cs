using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RealStateApiBackend.DataAcces;
using RealStateApiBackend.Models.DataModels;
using RealStateApiBackend.Services.User;

namespace RealStateApiBackend.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SearchHousesController : ControllerBase
    {
        private readonly RealStateDBContext _context;
        private readonly ISearchHouseService _searchHouseService;

        public SearchHousesController(RealStateDBContext context, ISearchHouseService searchHouseService)
        {
            _context = context;
            _searchHouseService = searchHouseService;
        }

        [HttpGet]
        public async Task<ActionResult<House>> GetHouse(SearchHouse searchHouse)
        {
            var houses = await _searchHouseService.GetHouseAsync(searchHouse);

            if (houses == null)
            {
                return NotFound();
            }

            return houses;
        }
    }
}
