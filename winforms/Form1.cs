using Microsoft.AspNetCore.Components.WebView.WindowsForms;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization.Json;
using System.Text;
using System.Windows.Forms;
using winforms.Components;
using winforms.Models;
using winforms.Services;

namespace winforms
{
    public partial class frmDataVisualizer : Form
    {
        private PropertyChangeNotifier _propertyChangeNotifier = new();
        private List<WeatherForecast> _weatherForecasts = new();

        public frmDataVisualizer()
        {
            InitializeComponent();

            var serviceCollection = new ServiceCollection();
            serviceCollection.AddWindowsFormsBlazorWebView();
            serviceCollection.AddSingleton(_propertyChangeNotifier);
            blazorWebView1.HostPage = "wwwroot/index.html";
            blazorWebView1.Services = serviceCollection.BuildServiceProvider();
            blazorWebView1.RootComponents.Add<WeatherForecastsGridView>("#app", new Dictionary<string, object> { { "WeatherForecasts", _weatherForecasts } });
        }

        private void btnLoadFile_Click(object sender, EventArgs e)
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
                        dgwData.AutoGenerateColumns = true;
                        dgwData.DataSource = data;

                        _weatherForecasts.Clear();
                        _weatherForecasts.AddRange(data);
                        _propertyChangeNotifier.NotifyPropertyChange("WeatherForecasts");
                        
                        ms.Close();
                    }
                }
            }
        }
    }
}
