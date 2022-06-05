using RestSharp;

namespace MaddoMeteoMaui.Data;

public class WeatherForecastService
{
	private static readonly string[] Summaries = new[]
	{
		"Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
	};

	public async Task<WeatherForecast> GetForecastAsync()
    {

        var client = new RestClient("http://192.168.100.170");
        var request = new RestRequest();
        var response = await client.GetAsync<WeatherForecast>(request);

        return response;


        //return Task.FromResult(Enumerable.Range(1, 5).Select(index => new WeatherForecast
        //{
        //	Date = startDate.AddDays(index),
        //	TemperatureC = Random.Shared.Next(-20, 55),
        //	Summary = Summaries[Random.Shared.Next(Summaries.Length)]
        //}).ToArray());
    }
}

