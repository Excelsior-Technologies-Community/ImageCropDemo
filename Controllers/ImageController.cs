using Microsoft.AspNetCore.Mvc;
using ImageCropDemo.Data;
using ImageCropDemo.Models;

namespace ImageCropDemo.Controllers
{
    public class ImageController : Controller
    {
        private readonly IWebHostEnvironment _env;
        private readonly AppDbContext _db;

        public ImageController(IWebHostEnvironment env, AppDbContext db)
        {
            _env = env;
            _db = db;
        }

        public IActionResult Upload()
        {
            return View();
        }

        [HttpPost]
        [IgnoreAntiforgeryToken]
        public IActionResult Save([FromBody] ImageCropRequest request)
        {
            if (string.IsNullOrEmpty(request.ImageBase64))
                return BadRequest();

            var base64 = request.ImageBase64.Split(',')[1];
            var bytes = Convert.FromBase64String(base64);

            var folder = Path.Combine(_env.WebRootPath, "uploads");
            if (!Directory.Exists(folder))
                Directory.CreateDirectory(folder);

            var fileName = Guid.NewGuid() + ".png";
            var path = Path.Combine(folder, fileName);

            System.IO.File.WriteAllBytes(path, bytes);

            _db.CroppedImages.Add(new CroppedImage
            {
                ImagePath = "/uploads/" + fileName,
                CreatedAt = DateTime.Now
            });
            _db.SaveChanges();

            return Json(new { path = "/uploads/" + fileName });
        }

        public IActionResult List()
        {
            return View(_db.CroppedImages.ToList());
        }
    }
}
