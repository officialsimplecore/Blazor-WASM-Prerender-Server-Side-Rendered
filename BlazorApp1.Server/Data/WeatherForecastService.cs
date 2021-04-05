using System;
using System.Linq;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading;
using System.Threading.Tasks;
using BlazorApp1.Shared;
using BlazorApp1.Shared.Models;

namespace BlazorApp1.Server.Data
{
    public class WeatherForecastService : IWeatherForecastService
    {
        private static readonly string[] Summaries = new[]
        {
            "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
        };

        public async Task<WeatherForecast[]> GetForecastAsync()
        {
            /* Option with pulling from the same text file */
            // string text = await System.IO.File.ReadAllTextAsync(
            //     @"weather.json");
            //
            // return JsonSerializer.Deserialize<WeatherForecast[]>(text);

            /* Option where nothing is returned */
            
            return null;
            
            /* Option where it is randomly generated (mocking DB call) */
            // var rng = new Random();
            // Thread.Sleep(1000);
            // return Enumerable.Range(1, 5).Select(index => new WeatherForecast
            //     {
            //         Date = DateTime.Now.AddDays(index),
            //         TemperatureC = rng.Next(-20, 55),
            //         Summary = Summaries[rng.Next(Summaries.Length)]
            //     })
            //     .ToArray();
        }
    }
}