using System.Text.Json.Serialization;

namespace MaddoMeteoMaui.Data;

public class WeatherForecast
{
	public float Winddir { get; set; }
    [JsonPropertyName("windspeedkmh")]
	public float WindSpeedKmh { get; set; }
    [JsonPropertyName("windgustkmh")]
	public float WindGustKmh { get; set; }
    [JsonPropertyName("windgustdir")]
	public float WindGustDir { get; set; }
	public float Humidity { get; set; }
	public float Tempf { get; set; }
	public float Tempc { get; set; }
	public float TempExtC { get; set; }
    [JsonPropertyName("rainmm")]
	public float RainMm { get; set; }
	public float DailyRainIn { get; set; }
	public double Pressure { get; set; }
    [JsonPropertyName("batt_lvl")]
	public float BattLvl { get; set; }
    [JsonPropertyName("light_lvl")]
    public float LightLvl { get; set; }
}
