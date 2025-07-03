namespace RapidApiConsume.Models
{
    public class Rootobject
    {
        public bool status { get; set; }
        public string? message { get; set; }
        public long timestamp { get; set; }
        public Data? data { get; set; }
    }

    public class Data
    {
        public string? base_currency { get; set; }
        public Exchange_Rates[]? exchange_rates { get; set; }
        public string? base_currency_date { get; set; }
    }

    public class ExchangeViewModel
    {
        public Exchange_Rates[] exchange_rates { get; set; }
        public string base_currency { get; set; }
        public string base_currency_date { get; set; }
    }

    public class Exchange_Rates
    {
        public string exchange_rate_buy { get; set; }
        public string currency_name { get; set; }
        public string exchange_rate_sell { get; set; }
        public string? currency { get; set; } // Eski API için uyumluluk
    }
}