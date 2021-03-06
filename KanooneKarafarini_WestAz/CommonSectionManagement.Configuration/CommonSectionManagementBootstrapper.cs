using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _01_Query.Contract.AboutContactUs;
using _01_Query.Contract.Footer;
using _01_Query.Query;
using CommonSectionManagement.Application;
using CommonSectionManagement.Application.Contract.AboutContactUs;
using CommonSectionManagement.Application.Contract.Footer;
using CommonSectionManagement.Domain.AboutContactUs;
using CommonSectionManagement.Domain.Footer;
using CommonSectionManagement.Infrastructure.EFCore;
using CommonSectionManagement.Infrastructure.EFCore.Repository;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace CommonSectionManagement.Configuration
{
    public class CommonSectionManagementBootstrapper
    {
        public static void Configure(IServiceCollection services, string connectionString)
        {
            services.AddTransient<IFooterRepository, FooterRepository>();
            services.AddTransient<IFooterApplication, FooterApplication>();

            services.AddTransient<IAboutContactUsRepository, AboutContactUsRepository>();
            services.AddTransient<IAboutContactUsApplication, AboutContactUsApplication>();


            services.AddTransient<IFooterQuery, FooterQuery>();
            services.AddTransient<IAboutContactUsQuery, AboutContactUsQuery>();







            services.AddDbContext<CommonSectionContext>(x => x.UseSqlServer(connectionString));

        }
    }
}
