using Microsoft.EntityFrameworkCore;
using ImageCropDemo.Models;

namespace ImageCropDemo.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions options) : base(options) { }

        public DbSet<CroppedImage> CroppedImages { get; set; }
    }
}
