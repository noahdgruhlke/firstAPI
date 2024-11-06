using firstAPI.Domain.Models.Entities;
using firstAPI.Domain.Services;
using Microsoft.AspNetCore.Mvc;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;

namespace firstAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {

        private readonly ILogger<WeatherForecastController> _logger;
        private readonly IWeatherForecastService _weatherForecastService;

        public WeatherForecastController(ILogger<WeatherForecastController> logger, IWeatherForecastService weatherForecastService)
        {
            _logger = logger;
            _weatherForecastService = weatherForecastService;
        }

        [HttpGet(Name = "GetWeatherForecast")]
        public List<WeatherForecast> Get()
        {
            return _weatherForecastService.GetAll();
        }
    }

    public class BookElementController : ControllerBase
    {
        private readonly ILogger<BookElementController> _logger;
        private readonly IBookService _bookService;

        public BookElementController(ILogger<BookElementController> logger, IBookService bookService)
        {
            _logger = logger;
            _bookService = bookService;
        }
    }
}
