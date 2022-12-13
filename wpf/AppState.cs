﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using wpf.Models;

namespace wpf
{
    public class AppState
    {
        public event EventHandler AppStateChanged;

        public List<WeatherForecast> WeatherForecasts { get; private set; }

        public void SetWeatherForecasts(List<WeatherForecast> weatherForecasts)
        {
            WeatherForecasts = weatherForecasts;
            AppStateChanged?.Invoke(this, null);
        }
    }
}