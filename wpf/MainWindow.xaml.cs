using blzcomponents.Models;
using blzcomponents.Services;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Win32;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization.Json;
using System.Text;
using System.Windows;
using wpf.Services;

namespace wpf
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            var serviceCollection = new ServiceCollection();
            serviceCollection.AddWpfBlazorWebView();
            serviceCollection.AddSingleton<IWeatherForecastDataService, WeatherForecastDataService>();
            Resources.Add("services", serviceCollection.BuildServiceProvider());

            InitializeComponent();
        }

        private void btnLoadData_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            if (openFileDialog.ShowDialog() == true)
            {
                string json = File.ReadAllText(openFileDialog.FileName);
                using (var ms = new MemoryStream(Encoding.UTF8.GetBytes(json)))
                {
                    var ser = new DataContractJsonSerializer(typeof(List<WeatherForecast>));
                    var data = ser.ReadObject(ms) as List<WeatherForecast>;
                    dgData.AutoGenerateColumns = true;
                    dgData.ItemsSource = data;
                    ms.Close();
                }
            }
        }
    }
}
