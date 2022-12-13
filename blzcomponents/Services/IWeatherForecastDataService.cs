using blzcomponents.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace blzcomponents.Services
{
    public interface IWeatherForecastDataService
    {
        Task<List<WeatherForecast>> GetWeatherForecastsAsync();
    }
}
