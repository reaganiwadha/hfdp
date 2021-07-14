using System;
using System.Threading.Tasks;

namespace c02_WeatherORama
{
    public interface IWeatherDataPublisher
    {
        public event EventHandler<WeatherUpdatedEventArgs> WeatherUpdatedEvent;
    }
    
    public class WeatherUpdatedEventArgs : EventArgs
    {
        public WeatherUpdatedEventArgs(string message)
        {
            Message = message;
        }
        
        public string Message { get; set; }
    }
    
    public class WeatherData : IWeatherDataPublisher
    {
        public event EventHandler<WeatherUpdatedEventArgs> WeatherUpdatedEvent;
        
        public void TryPublishEvent()
        {
            var task = Task.Run(async () =>
            {
                while (true)
                {
                    Console.WriteLine("Sending my hellos");
                    OnWeatherUpdated(new WeatherUpdatedEventArgs("hello"));
                    await Task.Delay(1000);
                }
            });

            task.Wait();
        }
        
        protected virtual void OnWeatherUpdated(WeatherUpdatedEventArgs e)
        {
            WeatherUpdatedEvent?.Invoke(this, e);
        }
    }

    public class WeatherScreen
    {
        private readonly string screenId;
        
        public WeatherScreen(IWeatherDataPublisher data)
        {
            screenId = Guid.NewGuid().ToString();
            data.WeatherUpdatedEvent += HandleWeatherUpdatedEvent;
        }

        private void HandleWeatherUpdatedEvent(object sender, WeatherUpdatedEventArgs e)
        {
            Console.WriteLine($"{screenId} got {e.Message}");
        }
    }
}