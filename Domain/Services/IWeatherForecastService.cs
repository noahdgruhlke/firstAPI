using firstAPI.Domain.Models.Entities;

namespace firstAPI.Domain.Services
{
    public interface IWeatherForecastService
    {
        List<WeatherForecast> GetAll();
    }
}
