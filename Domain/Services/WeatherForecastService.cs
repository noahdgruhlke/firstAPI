using firstAPI.Domain.Managers.Repositories;
using firstAPI.Domain.Models.Entities;

namespace firstAPI.Domain.Services
{
    public class WeatherForecastService : IWeatherForecastService
    {
        private readonly IWeatherForecastRepositories _weatherForecastRepositories;
        public WeatherForecastService(IWeatherForecastRepositories weatherForecastRepositories)
        {
            _weatherForecastRepositories = weatherForecastRepositories;
        }
        public List<WeatherForecast> GetAll()
        {
            return _weatherForecastRepositories.GetAll();
        }
    }
}
