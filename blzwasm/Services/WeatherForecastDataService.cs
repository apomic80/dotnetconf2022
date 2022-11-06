using blzcomponents.Services;
using blzcomponents.Models;
using System.Net.Http.Json;

namespace blzwasm.Services
{
    public class WeatherForecastDataService : IWeatherForecastDataService
    {
        private readonly HttpClient _httpClient;

        public WeatherForecastDataService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public Task<List<WeatherForecast>> GetWeatherForecastsAsync()
        {
            return _httpClient.GetFromJsonAsync<List<WeatherForecast>>("sample-data/weather.json");
        }
    }
}
