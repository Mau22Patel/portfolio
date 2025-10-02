using System;
using System.Configuration;
using System.Net.Http;
using System.Threading.Tasks;
using Newtonsoft.Json;
using System.Configuration;


namespace WeatherApp
{
    public sealed class WeatherApiService : IDisposable
    {
        private readonly HttpClient _http = new HttpClient { BaseAddress = new Uri("https://api.weatherapi.com/") };
        private readonly string _key;

        public WeatherApiService()
        {
            _key = ConfigurationManager.AppSettings["WeatherApiKey"];
            if (string.IsNullOrWhiteSpace(_key))
                throw new InvalidOperationException("Missing WeatherApiKey in App.config.");

            _http.Timeout = TimeSpan.FromSeconds(15);
        }

        /// <summary>
        /// Gets current weather + today’s sunrise/sunset in one call.
        /// </summary>
        public async Task<WaForecastRoot> GetByCityAsync(string city)
        {
            var url = string.Format(
                "v1/forecast.json?key={0}&q={1}&days=1&aqi=no&alerts=no",
                _key,
                Uri.EscapeDataString(city)
            );

            HttpResponseMessage resp = await _http.GetAsync(url);
            string json = await resp.Content.ReadAsStringAsync();

            if (!resp.IsSuccessStatusCode)
                throw new HttpRequestException(
                    string.Format("API {0}: {1}", (int)resp.StatusCode, json)
                );

            return JsonConvert.DeserializeObject<WaForecastRoot>(json);
        }

        public static Uri NormalizeIconUri(string iconFromApi)
        {
            var s = (iconFromApi ?? "").Trim();
            if (s.StartsWith("//")) s = "https:" + s;
            return new Uri(s);
        }

        public void Dispose()
        {
            _http.Dispose();
        }
    }
}
