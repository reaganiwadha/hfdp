using System;

namespace c02_WeatherORama
{
    // use C#'s events    
    class Program
    {
        static void Main(string[] args)
        {
            var weatherData = new WeatherData();
            var screen1 = new WeatherScreen(weatherData);
            var screen2 = new WeatherScreen(weatherData);
            weatherData.TryPublishEvent();
        }
    }
}