namespace RapidApiConsume.Models
{
    public class BookingApiViewModel
    {
        public string status { get; set; }
        public string message { get; set; }
        public long timestamp { get; set; }
        public List<Result> data { get; set; }
    }

    public class Result
    {
        public string hotel_id { get; set; }
        public string accessibilityLabel { get; set; }
        public object property { get; set; }
        public string property_id { get; set; }
        public string main_photo_id { get; set; }
        public string photo_id { get; set; }
        public string review_score_word { get; set; }
        public string hotel_name { get; set; }
        public string hotel_name_trans { get; set; }
        public int is_city_center { get; set; }
        public string distance_to_cc { get; set; }
        public string chosen_currency { get; set; }
        public string min_total_price { get; set; }
        public int price_is_final { get; set; }
        public string max_photo_url { get; set; }
        public string review_score { get; set; }
        public string accommodation_type_name { get; set; }
        public string city_trans { get; set; }
        public string district { get; set; }
        public string country_trans { get; set; }
        public string in_best_district { get; set; }
        public int is_beach_front { get; set; }
        public List<string> hotel_class { get; set; }
        public int deals_smart_deal { get; set; }
        public int extended { get; set; }
        public int is_smart_deal { get; set; }
        public int cant_book { get; set; }
        public string currency_code { get; set; }
        public string address { get; set; }
        public string city_name_en { get; set; }
        public int soldout { get; set; }
        public int is_no_prepayment_block { get; set; }
        public int main_photo_url { get; set; }
        public int is_geo_rate { get; set; }
        public string composite_price_breakdown { get; set; }
        public int deals_deal_smart { get; set; }
        public string latitude { get; set; }
        public string longitude { get; set; }
        public string hotel_include_breakfast { get; set; }
        public int unit_configuration_label { get; set; }
        public int review_nr { get; set; }
        public int accommodation_type { get; set; }
        public List<string> hotel_facilities { get; set; }
        
        // Ek property'ler (eski API yanıtı için uyumluluk)
        public string name { get; set; }
        public string city_name { get; set; }
        public string dest_type { get; set; }
        public string label { get; set; }
        public string country { get; set; }
        public string region { get; set; }
        public int? nr_hotels { get; set; }
        public string image_url { get; set; }
    }
}
