using Microsoft.AspNetCore.Mvc;
using web.Services.Interfaces;

namespace WeatherForecast.Web.Controllers
{
    public class WeatherForecastController : Controller
    {
        private readonly IWeatherForecastService _service;

        public WeatherForecastController(IWeatherForecastService service)
        {
            _service = service ?? throw new ArgumentNullException(nameof(service));
        }

        public async Task<IActionResult> Index()
        {
            var products = await _service.Find();
            return View(products);
        }
    }
}