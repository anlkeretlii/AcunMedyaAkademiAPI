using Newtonsoft.Json;

namespace RapidApiConsume.Models
{
    public class ApiMovieViewModel
    {
        [JsonProperty("rank")]
        public string Rank { get; set; }
        
        [JsonProperty("title")]
        public string Title { get; set; }
        
        [JsonProperty("thumbnail")]
        public string Thumbnail { get; set; }
        
        [JsonProperty("rating")]
        public string Rating { get; set; }
        
        [JsonProperty("id")]
        public string Id { get; set; }
        
        [JsonProperty("year")]
        public int Year { get; set; }
        
        [JsonProperty("image")]
        public string Image { get; set; }
        
        [JsonProperty("description")]
        public string Description { get; set; }
        
        [JsonProperty("trailer")]
        public string Trailer { get; set; }
        
        [JsonProperty("genre")]
        public List<string> Genre { get; set; }
        
        [JsonProperty("director")]
        public string Director { get; set; }
        
        [JsonProperty("writers")]
        public List<string> Writers { get; set; }
        
        [JsonProperty("imdbid")]
        public string Imdbid { get; set; }
    }
}