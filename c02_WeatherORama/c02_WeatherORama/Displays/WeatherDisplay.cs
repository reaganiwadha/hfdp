namespace c02_WeatherORama.Displays
{
    public abstract class WeatherDisplay
    {
        protected abstract void HandleWeatherUpdatedEvent(object sender, WeatherUpdatedEventArgs e);
        public abstract void Display();
    }
}