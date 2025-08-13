namespace HotelProjectWebUI.Dtos.DashboardDto
{
    public class SocialMediaDashboardDto
    {
        public ResultInstagramFollowersDto Instagram { get; set; } = new();
        public ResultTwitterFollowersDto Twitter { get; set; } = new();
    }
}
