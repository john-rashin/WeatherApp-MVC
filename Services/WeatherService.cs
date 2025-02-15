using System.Net.Http;
using System.Threading.Tasks;
using Newtonsoft.Json;

public class WeatherService
{
    private readonly HttpClient _httpClient;
    private const string API_KEY = "35ce123b33ffd181373c9d0ed4983b87";
    
    public WeatherService()
    {
        _httpClient = new HttpClient();
    }

    public async Task<WeatherModel> GetWeatherAsync(string city)
    {
        string url = $"https://api.openweathermap.org/data/2.5/weather?q={city}&appid={API_KEY}&units=metric";
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
