using ModelContextProtocol.Server;
using ModelContextProtocol.WebApi.Models;
using ModelContextProtocol.WebApi.Services;
using System.ComponentModel;

namespace ModelContextProtocol.WebApi.MCP
{
    [McpServerToolType]
    public static class MyMCPTool
    {
        [McpServerTool, Description("Verilen şehir bilgisine göre o şehrin sıcıklığını döndürür")]
        public static Weather GetWeather([Description("Şehir Bilgisi")]string city, WeatherServices weatherServices)
        {
            return weatherServices.Get(city) ?? throw new NullReferenceException(nameof(city));
        }
    }
}
