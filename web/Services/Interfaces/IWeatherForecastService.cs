using web.Models;

namespace web.Services.Interfaces
{
    public interface IWeatherForecastService
    {
        Task<IEnumerable<WeatherForecastModel>> Find();
    }
}
