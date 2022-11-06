using blzcomponents.Models;
using blzcomponents.Services;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Json;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace winforms.Services
{
    public class WeatherForecastDataService : IWeatherForecastDataService
    {
        public Task<List<WeatherForecast>> GetWeatherForecastsAsync()
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                if (openFileDialog.ShowDialog() == DialogResult.OK)
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
}
