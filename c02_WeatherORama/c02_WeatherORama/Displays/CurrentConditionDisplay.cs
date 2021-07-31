using System;

namespace c02_WeatherORama.Displays
{
    public class CurrentConditionDisplay : WeatherDisplay
    {
        private float _temperature;
        private float _humidity;
        
        public CurrentConditionDisplay(IWeatherDataPublisher weatherDataPublisher)
        {
            weatherDataPublisher.WeatherUpdatedEvent += HandleWeatherUpdatedEvent;
        }

        protected override void HandleWeatherUpdatedEvent(object sender, WeatherUpdatedEventArgs e)
        {
            _temperature = e.Temperature;
            _humidity = e.Humidity;
            Display();
        }

        public override void Display()
        {
            Console.WriteLine($"Current condition: {_temperature}C degrees and {_humidity}% humidity");
        }
    }
}