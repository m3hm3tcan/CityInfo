using CityInfo.API.Models;
using Microsoft.AspNetCore.Mvc;

namespace CityInfo.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CitiesController : ControllerBase
    {
        [HttpGet("getAll")]
        public ActionResult<IEnumerable<CityDto>> GetCities() 
        {
            return Ok(CityDataStore.Current.Cities);
        }
        [HttpGet("{id}")]
        public ActionResult<CityDto> GetCity(int id) 
        {
            var city = CityDataStore.Current.Cities.FirstOrDefault(c => c.Id == id);

            if(city == null)
            {
                return NotFound();
            }
            return Ok(city);
        }
    }
}
