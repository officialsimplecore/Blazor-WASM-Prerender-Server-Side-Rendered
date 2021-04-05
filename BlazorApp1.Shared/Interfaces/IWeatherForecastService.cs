using System.Threading.Tasks;
using BlazorApp1.Shared.Models;

namespace BlazorApp1.Shared
{
    public interface IWeatherForecastService
    {
        Task<WeatherForecast[]> GetForecastAsync();
    }
}