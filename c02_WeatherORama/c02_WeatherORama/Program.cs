using c02_WeatherORama.Displays;

namespace c02_WeatherORama
{
    class WeatherORama
    {
        static void Main(string[] args)
        {
            var weatherData = new WeatherData();
            var screen1 = new CurrentConditionDisplay(weatherData);
            weatherData.SetMeasurements(50, 20, 30);
        }
    }
}