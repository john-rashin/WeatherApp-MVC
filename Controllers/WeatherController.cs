using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

public class WeatherController : Controller
{
    private readonly WeatherService _weatherService;

    public WeatherController(IConfiguration configuration)
    {
        _weatherService = new WeatherService(configuration);
    }
 
    public IActionResult Index()
    {
        return View();
    }

    [HttpPost]
    public async Task<IActionResult> GetWeather(string city)
    {
        var weather = await _weatherService.GetWeatherAsync(city);
        return Json(weather);
    }
}
