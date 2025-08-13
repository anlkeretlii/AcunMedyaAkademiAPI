namespace HotelProjectWebUI.Dtos.DashboardDto
{
    public class TwitterApiResponseDto
    {
        public string? status { get; set; }
        public TwitterData? data { get; set; }
        
        public class TwitterData
        {
            public string? fullname { get; set; }
            public string? username { get; set; }
            public string? bio { get; set; }
            public TwitterStats? stats { get; set; }
        }
        
        public class TwitterStats
        {
            public string? posts { get; set; }
            public string? following { get; set; }
            public string? followers { get; set; }
            public string? likes { get; set; }
        }
    }
}