using ImageGalleryManagement.Domain.Managers;
using ImageGalleryManagement.Domain.PictureGallery;
using ImageGalleryManagement.Domain.Slider;
using ImageGalleryManagement.Infrastructure.EFCore.Mapping;
using Microsoft.EntityFrameworkCore;

namespace ImageGalleryManagement.Infrastructure.EFCore
{
    public class ImageGalleryContext : DbContext
    {
        public DbSet<Slider> Sliders { get; set; }
        public DbSet<PictureGallery> PictureGalleries { get; set; }
        public DbSet<Managers> Managers { get; set; }




        public ImageGalleryContext(DbContextOptions<ImageGalleryContext> options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            var assembly = typeof(SliderMapping).Assembly;
            modelBuilder.ApplyConfigurationsFromAssembly(assembly);
            base.OnModelCreating(modelBuilder);
        }
    }
}
