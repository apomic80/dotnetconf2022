using blzcomponents.Models;

namespace blzcomponents.Services
{
    public interface IWeatherForecastDataService
    {
        Task<List<WeatherForecast>> GetWeatherForecastsAsync();
    }
}
