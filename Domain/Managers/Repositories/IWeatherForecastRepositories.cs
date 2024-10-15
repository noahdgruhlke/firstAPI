using firstAPI.Domain.Models.Entities;

namespace firstAPI.Domain.Managers.Repositories
{
    public interface IWeatherForecastRepositories
    {
        List<WeatherForecast> GetAll();
    }
}
