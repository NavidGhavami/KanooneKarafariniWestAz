using ImageGalleryManagement.Application;
using ImageGalleryManagement.Application.Contract.PictureGallery;
using ImageGalleryManagement.Application.Contract.Slider;
using ImageGalleryManagement.Domain.PictureGallery;
using ImageGalleryManagement.Domain.Slider;
using ImageGalleryManagement.EFCore.Repository;
using ImageGalleryManagement.Infrastructure.EFCore.Repository;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using ShopManagement.Infrastructure.EFCore;

namespace ImageGalleryManagement.Configuration
{
    public class ImageGalleryManagementBootstrapper
    {
        public static void Configure(IServiceCollection services, string connectionString)
        {
            services.AddTransient<ISliderRepository, SliderRepository>();
            services.AddTransient<ISliderApplication, SliderApplication>();

            services.AddTransient<IPictureGalleryRepository, PictureGalleryRepository>();
            services.AddTransient<IPictureGalleryApplication, PictureGalleryApplication>();













            services.AddDbContext<ImageGalleryContext>(x => x.UseSqlServer(connectionString));

        }
    }
}
