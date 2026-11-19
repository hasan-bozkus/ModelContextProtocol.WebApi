namespace ModelContextProtocol.WebApi.Models
{
    public sealed class Weather
    {
        public string City { get; set; } = default!;
        public int Temp { get; set; }
    }
}
