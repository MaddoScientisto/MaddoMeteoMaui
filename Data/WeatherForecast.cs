using System.Text.Json.Serialization;

namespace MaddoMeteoMaui.Data;

public class WeatherForecast
{
	public float Winddir { get; set; }
	public float WindSpeedKmh { get; set; }
	public float WindGustKmh { get; set; }
	public float WindGustDir { get; set; }
	public float Humidity { get; set; }
	public float Tempf { get; set; }
	public float Tempc { get; set; }
	public float TempExtC { get; set; }
	public float RainMm { get; set; }
	public float DailyRainIn { get; set; }
	public float Pressure { get; set; }
    [JsonPropertyName("batt_lvl")]
	public float BattLvl { get; set; }
    [JsonPropertyName("light_lvl")]
    public float LightLvl { get; set; }
}
