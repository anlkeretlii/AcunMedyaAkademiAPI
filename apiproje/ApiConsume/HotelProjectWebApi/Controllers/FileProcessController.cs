using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace HotelProjectWebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FileProcessController : ControllerBase
    {
        [HttpPost]
        [RequestSizeLimit(10_000_000)] // 10MB limit
        [ProducesResponseType(201)]
        [ProducesResponseType(400)]
        public async Task<IActionResult> UploadFile(IFormFile file)
        {
            if (file == null || file.Length == 0)
                return BadRequest("No file uploaded.");

            try
            {
                var fileName = Guid.NewGuid() + Path.GetExtension(file.FileName);
                var filesPath = Path.Combine(Directory.GetCurrentDirectory(), "files");
                
                // files klasörü yoksa oluştur
                if (!Directory.Exists(filesPath))
                    Directory.CreateDirectory(filesPath);

                var path = Path.Combine(filesPath, fileName);
                
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