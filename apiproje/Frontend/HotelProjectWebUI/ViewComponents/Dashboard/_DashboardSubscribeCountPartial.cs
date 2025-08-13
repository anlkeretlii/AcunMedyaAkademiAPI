using HotelProjectWebUI.Dtos.DashboardDto;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;


namespace HotelProjectWebUI.ViewComponents.Dashboard
{
    public class _DashboardSubscribeCountPartial : ViewComponent
    {
        private readonly ILogger<_DashboardSubscribeCountPartial> _logger;

        public _DashboardSubscribeCountPartial(ILogger<_DashboardSubscribeCountPartial> logger)
        {
            _logger = logger;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            _logger.LogInformation("Dashboard Subscribe Count Partial başlatılıyor...");
            var socialMediaData = new SocialMediaDashboardDto();

            // Instagram API çağrısı
            _logger.LogInformation("Instagram API çağrısı başlatılıyor...");
            try
            {
                var client = new HttpClient();
                var request = new HttpRequestMessage
                {
                    Method = HttpMethod.Get,
                    RequestUri = new Uri("https://instagram-scraper-stable-api.p.rapidapi.com/ig_get_fb_profile_hover.php?username_or_url=anlkeretlii"),
                    Headers =
                    {
                        { "x-rapidapi-key", "cc78fe0c86msha5ad1c5ec2de2a5p10e976jsnb392ebddfebc" },
                        { "x-rapidapi-host", "instagram-scraper-stable-api.p.rapidapi.com" },
                    },
                };
                
                _logger.LogInformation("Instagram API request gönderiliyor...");
                using (var response = await client.SendAsync(request))
                {
                    _logger.LogInformation($"Instagram API response status: {response.StatusCode}");
                    response.EnsureSuccessStatusCode();
                    var body = await response.Content.ReadAsStringAsync();
                    _logger.LogInformation($"Instagram API response body: {body}");
                    
                    var apiResponse = JsonConvert.DeserializeObject<InstagramApiResponseDto>(body);
                    socialMediaData.Instagram = apiResponse?.user_data ?? new ResultInstagramFollowersDto();
                    _logger.LogInformation($"Instagram followers: {socialMediaData.Instagram.follower_count}");
                }
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Instagram API hatası: {ErrorMessage}", ex.Message);
                // Instagram API hatası durumunda varsayılan değerler
                socialMediaData.Instagram = new ResultInstagramFollowersDto();
            }

            // Twitter API çağrısı
            _logger.LogInformation("Twitter API çağrısı başlatılıyor...");
            try
            {
                var client2 = new HttpClient();
                var request2 = new HttpRequestMessage
                {
                    Method = HttpMethod.Get,
                    RequestUri = new Uri("https://twitter32.p.rapidapi.com/profile?username=nike"),
                    Headers =
                    {
                        { "x-rapidapi-key", "cc78fe0c86msha5ad1c5ec2de2a5p10e976jsnb392ebddfebc" },
                        { "x-rapidapi-host", "twitter32.p.rapidapi.com" },
                    },
                };
                
                _logger.LogInformation("Twitter API request gönderiliyor...");
                using (var response2 = await client2.SendAsync(request2))
                {
                    _logger.LogInformation($"Twitter API response status: {response2.StatusCode}");
                    response2.EnsureSuccessStatusCode();
                    var body2 = await response2.Content.ReadAsStringAsync();
                    _logger.LogInformation($"Twitter API response body: {body2}");
                    
                    var apiResponseTwitter = JsonConvert.DeserializeObject<TwitterApiResponseDto>(body2);
                    _logger.LogInformation($"Twitter API deserialize sonrası: status={apiResponseTwitter?.status}, data={apiResponseTwitter?.data != null}, stats={apiResponseTwitter?.data?.stats != null}");
                    
                    if (apiResponseTwitter?.status == "ok" && apiResponseTwitter?.data?.stats != null)
                    {
                        socialMediaData.Twitter = new ResultTwitterFollowersDto
                        {
                            followers_count = apiResponseTwitter.data.stats.followers ?? "0",
                            friends_count = apiResponseTwitter.data.stats.following ?? "0",
                            username = apiResponseTwitter.data.username ?? "",
                            fullname = apiResponseTwitter.data.fullname ?? ""
                        };
                        _logger.LogInformation($"Twitter verileri başarıyla alındı: followers={socialMediaData.Twitter.followers_count}, following={socialMediaData.Twitter.friends_count}");
                    }
                    else
                    {
                        _logger.LogWarning("Twitter API response'da stats bulunamadı, varsayılan değerler kullanılıyor");
                        socialMediaData.Twitter = new ResultTwitterFollowersDto();
                    }
                }
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Twitter API hatası: {ErrorMessage}", ex.Message);
                // Twitter API hatası durumunda varsayılan değerler
                socialMediaData.Twitter = new ResultTwitterFollowersDto();
            }

            _logger.LogInformation("Social media data hazırlandı, view döndürülüyor");
            return View(socialMediaData);
        }
    }
}
