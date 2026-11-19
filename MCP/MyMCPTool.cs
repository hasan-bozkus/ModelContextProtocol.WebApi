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
        public static Weather GetWeather([Description("Şehir Bilgisi")]string city, WeatherServices weatherServices, IHttpContextAccessor httpContextAccessor)
        {
            return weatherServices.Get(city) ?? throw new NullReferenceException(nameof(city));
        }

        [McpServerTool, Description("Personellerin tarih bazlı satış listesini döndürür")]
        public static List<Sale> GetSales()
        {
            return Sale.Sales;
        }

        [McpServerTool, Description("Yapılacak ödemelerin son tarihlerini döndürür")]
        public static List<Payment> GetPayments()
        {
            return Payment.Payments;
        }
    }
}
