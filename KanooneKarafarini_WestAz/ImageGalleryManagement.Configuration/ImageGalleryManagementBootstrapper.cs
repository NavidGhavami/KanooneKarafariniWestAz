using _01_Query.Contract.Managers;
using _01_Query.Contract.Partners;
using _01_Query.Contract.PictureGallery;
using _01_Query.Contract.Slider;
using _01_Query.Query;
using ImageGalleryManagement.Application;
using ImageGalleryManagement.Application.Contract.Managers;
using ImageGalleryManagement.Application.Contract.Partners;
using ImageGalleryManagement.Application.Contract.PictureGallery;
using ImageGalleryManagement.Application.Contract.Slider;
using ImageGalleryManagement.Domain.Managers;
using ImageGalleryManagement.Domain.Partners;
using ImageGalleryManagement.Domain.PictureGallery;
using ImageGalleryManagement.Domain.Slider;
using ImageGalleryManagement.EFCore.Repository;
using ImageGalleryManagement.Infrastructure.EFCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

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

            services.AddTransient<IManagersRepository, ManagerRepository>();
            services.AddTransient<IManagersApplication, ManagersApplication>();

            services.AddTransient<IPartnersRepository, PartnersRepository>();
            services.AddTransient<IPartnersApplication, PartnersApplication>();



            services.AddTransient<ISliderQuery, SliderQuery>();
            services.AddTransient<IPictureGalleryQuery, PictureGalleryQuery>();
            services.AddTransient<IManagerQuery, ManagerQuery>();
            services.AddTransient<IPartnerQuery, PartnerQuery>();





            services.AddDbContext<ImageGalleryContext>(x => x.UseSqlServer(connectionString));

        }
    }
}
