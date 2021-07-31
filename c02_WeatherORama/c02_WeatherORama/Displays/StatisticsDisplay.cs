using System;
using System.Collections.Generic;
using System.Linq;

namespace c02_WeatherORama.Displays
{
    public class StatisticsDisplay : WeatherDisplay
    {
        private readonly List<float> _temperatures = new List<float>();

        public StatisticsDisplay(IWeatherDataPublisher weatherDataPublisher)
        {
            weatherDataPublisher.WeatherUpdatedEvent += HandleWeatherUpdatedEvent;
        }
        
        protected override void HandleWeatherUpdatedEvent(object sender, WeatherUpdatedEventArgs e)
        {
            _temperatures.Add(e.Temperature);
            Display();
        }

        public override void Display()
        {
            Console.WriteLine($"Average temp : {_temperatures.Average()}");
        }
    }
}