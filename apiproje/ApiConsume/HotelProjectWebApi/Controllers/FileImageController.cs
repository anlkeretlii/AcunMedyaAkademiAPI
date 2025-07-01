using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace HotelProjectWebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FileImageController : ControllerBase
    {
        [HttpPost]
        [RequestSizeLimit(10_000_000)] // 10MB limit
        [ProducesResponseType(201)]
        [ProducesResponseType(400)]
        public async Task<IActionResult> UploadImage(IFormFile file)
        {
            if (file == null || file.Length == 0)
                return BadRequest("No file uploaded.");

            try
            {
                var fileName = Guid.NewGuid() + Path.GetExtension(file.FileName);
                var imagesPath = Path.Combine(Directory.GetCurrentDirectory(), "images");
                
                // images klasörü yoksa oluştur
                if (!Directory.Exists(imagesPath))
                    Directory.CreateDirectory(imagesPath);

                var path = Path.Combine(imagesPath, fileName);
                
                using (var stream = new FileStream(path, FileMode.Create))
                {
                    await file.CopyToAsync(stream);
                }
                
                return Created("", new { fileName = fileName });
            }
            catch (Exception ex)
            {
                return BadRequest($"Error uploading file: {ex.Message}");
            }
        }
    }
}