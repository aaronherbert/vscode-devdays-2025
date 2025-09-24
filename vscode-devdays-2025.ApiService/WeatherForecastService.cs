using System;
using System.Linq;

namespace vscode_devdays_2025.ApiService
{
    public interface IWeatherForecastService
    {
        WeatherForecast[] GetForecast(string[] summaries);
    }

    public class WeatherForecastService : IWeatherForecastService
    {
        public WeatherForecast[] GetForecast(string[] summaries)
        {
            return Enumerable.Range(1, 5).Select(index =>
                new WeatherForecast
                (
                    DateOnly.FromDateTime(DateTime.Now.AddDays(index)),
                    Random.Shared.Next(-20, 55),
                    summaries[Random.Shared.Next(summaries.Length)]
                )).ToArray();
        }
    }
}
