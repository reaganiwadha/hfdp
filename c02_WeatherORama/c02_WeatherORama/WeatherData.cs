using System;

namespace c02_WeatherORama
{
    public interface IWeatherDataPublisher
    {
        public event EventHandler<WeatherUpdatedEventArgs> WeatherUpdatedEvent;
    }
    
    public class WeatherUpdatedEventArgs : EventArgs
    {
        public WeatherUpdatedEventArgs(float temperature, float humidity, float pressure)
        {
            Temperature = temperature;
            Humidity = humidity;
            Pressure = pressure;
        }
        
        public float Temperature { get; set; }
        public float Humidity { get; set; }
        public float Pressure { get; set; }
    }
    
    public class WeatherData : IWeatherDataPublisher
    {
        public event EventHandler<WeatherUpdatedEventArgs> WeatherUpdatedEvent;
        
        private float _temperature;
        private float _humidity;
        private float _pressure;

        public void SetMeasurements(float temperature, float humidity, float pressure)
        {
            _temperature = temperature;
            _humidity = humidity;
            _pressure = pressure;
            OnWeatherUpdated();
        }
        
        protected virtual void OnWeatherUpdated()
        {
            WeatherUpdatedEvent?.Invoke(this, new WeatherUpdatedEventArgs(_temperature, _humidity, _pressure));
        }
    }
}