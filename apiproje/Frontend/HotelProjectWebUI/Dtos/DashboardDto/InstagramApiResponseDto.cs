namespace HotelProjectWebUI.Dtos.DashboardDto
{
    public class InstagramApiResponseDto
    {
        public ResultInstagramFollowersDto? user_data { get; set; }
    }
    public class ResultInstagramFollowersDto
    {
        public int follower_count { get; set; }
        public int following_count { get; set; }
    }
}
