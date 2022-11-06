using blzcomponents.Models;
using blzcomponents.Services;
using Microsoft.Win32;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization.Json;
using System.Text;
using System.Threading.Tasks;

namespace wpf.Services
{
    public class WeatherForecastDataService : IWeatherForecastDataService
    {
        public Task<List<WeatherForecast>> GetWeatherForecastsAsync()
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            if (openFileDialog.ShowDialog() == true)
            {
                string json = File.ReadAllText(openFileDialog.FileName);
                using (var ms = new MemoryStream(Encoding.UTF8.GetBytes(json)))
                {
                    var ser = new DataContractJsonSerializer(typeof(List<WeatherForecast>));
                    var data = ser.ReadObject(ms) as List<WeatherForecast>;
                    ms.Close();
                    return Task.FromResult(data);
                }
            }
            else return Task.FromResult(new List<WeatherForecast>());
        }
    }
}
