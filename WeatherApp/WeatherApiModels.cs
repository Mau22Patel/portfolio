using Newtonsoft.Json;

namespace WeatherApp
{
    public class WaForecastRoot
    {
        [JsonProperty("location")] public WaLocation Location { get; set; }
        [JsonProperty("current")] public WaCurrent Current { get; set; }
        [JsonProperty("forecast")] public WaForecast Forecast { get; set; }
    }

    public class WaLocation
    {
        [JsonProperty("name")] public string Name { get; set; }
        [JsonProperty("country")] public string Country { get; set; }
        [JsonProperty("tz_id")] public string Timezone { get; set; }
    }

    public class WaCurrent
    {
        [JsonProperty("temp_c")] public double TempC { get; set; }
        [JsonProperty("temp_f")] public double TempF { get; set; }
        [JsonProperty("is_day")] public int IsDay { get; set; }
        [JsonProperty("condition")] public WaCondition Condition { get; set; }
        [JsonProperty("wind_kph")] public double WindKph { get; set; }
        [JsonProperty("wind_mph")] public double WindMph { get; set; }
        [JsonProperty("pressure_mb")] public double PressureMb { get; set; }
        [JsonProperty("humidity")] public int Humidity { get; set; }
        [JsonProperty("last_updated_epoch")] public long LastUpdatedEpoch { get; set; }
    }

    public class WaCondition
    {
        [JsonProperty("text")] public string Text { get; set; }
        [JsonProperty("icon")] public string Icon { get; set; } // e.g. //cdn.weatherapi.com/...
    }

    public class WaForecast
    {
        [JsonProperty("forecastday")] public WaForecastDay[] Days { get; set; }
    }

    public class WaForecastDay
    {
        [JsonProperty("date_epoch")] public long DateEpoch { get; set; }
        [JsonProperty("astro")] public WaAstro Astro { get; set; }
    }

    public class WaAstro
    {
        [JsonProperty("sunrise")] public string Sunrise { get; set; } // "06:11 AM"
        [JsonProperty("sunset")] public string Sunset { get; set; } // "07:43 PM"
    }
}
