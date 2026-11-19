using ModelContextProtocol.WebApi.Models;

namespace ModelContextProtocol.WebApi.Services
{
    public sealed class WeatherServices
    {
        public static List<Weather> Weathers { get; set; } = new()
        {
            new () {City = "Kayseri", Temp = 12 },
            new () {City = "İstanbul", Temp = 34 },
            new () {City = "Mardin", Temp = 22 },
            new () {City = "Ankara", Temp = 30 },
        };

        public Weather Get(string city)
        {
            var weather= Weathers.FirstOrDefault(p => p.City == city);
            if(weather == null)
            {
                throw new NullReferenceException(nameof(weather));
            }
            return weather;
        }
    }
}
