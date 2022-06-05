using RestSharp;

namespace MaddoMeteoMaui.Data;

public class WeatherForecastService
{


	public async Task<WeatherForecast> GetForecastAsync(string address)
    {

        var client = new RestClient(address);
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

