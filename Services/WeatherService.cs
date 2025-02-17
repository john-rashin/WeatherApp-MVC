using System.Net.Http;
using System.Threading.Tasks;
using Newtonsoft.Json;

public class WeatherService
{
    private readonly HttpClient _httpClient;
    private readonly string _apiKey;
    
    public WeatherService(IConfiguration configuration)
    {
        _httpClient = new HttpClient();
        _apiKey = configuration["OpenWeatherMap:ApiKey"];
    }

    public async Task<WeatherModel> GetWeatherAsync(string city)
    {
        string url = $"https://api.openweathermap.org/data/2.5/weather?q={city}&appid={_apiKey}&units=metric";
        var response = await _httpClient.GetStringAsync(url);
        dynamic data = JsonConvert.DeserializeObject(response);

        return new WeatherModel
        {
            City = data.name,
            Temperature = data.main.temp,
            Humidity = data.main.humidity,
            Condition = data.weather[0].description
        };
    }
}
