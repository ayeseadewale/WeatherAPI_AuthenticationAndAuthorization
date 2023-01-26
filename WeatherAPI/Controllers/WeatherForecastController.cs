using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Swashbuckle.AspNetCore.Annotations;
using WeatherAPI.Domain.Model;
using WeatherAPI.infrastructure.Repository;

namespace WeatherAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {
        private IWeatherRepository _weatherService;

        public WeatherForecastController(IWeatherRepository weatherService)
        {
            _weatherService = weatherService;
        }

        [HttpGet(Name = "GetWeatherForecast"), Authorize]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [SwaggerOperation(Summary = "This is used for getting the weather details based on Location")]
        public async Task<IActionResult> Get(string location)
        {
            return Ok(await _weatherService.GetCurrentWeatherAsync(location));
        }
    }
}