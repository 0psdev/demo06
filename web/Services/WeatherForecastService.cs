using web.Helpers;
using web.Models;
using web.Services.Interfaces;

namespace web.Services
{
    public class WeatherForecastService : IWeatherForecastService
    {
        private readonly HttpClient _client;
        public const string BasePath = "/WeatherForecast";

        public WeatherForecastService(HttpClient client)
        {
            _client = client ?? throw new ArgumentNullException(nameof(client));
        }

        public async Task<IEnumerable<WeatherForecastModel>> Find()
        {
            var response = await _client.GetAsync(BasePath);

            return await response.ReadContentAsync<List<WeatherForecastModel>>();
        }
    }
}
