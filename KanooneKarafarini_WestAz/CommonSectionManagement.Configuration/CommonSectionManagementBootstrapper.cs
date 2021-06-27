using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _01_Query.Contract.Footer;
using _01_Query.Query;
using CommonSectionManagement.Application;
using CommonSectionManagement.Application.Contract.Footer;
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


            services.AddTransient<IFooterQuery, FooterQuery>();







            services.AddDbContext<CommonSectionContext>(x => x.UseSqlServer(connectionString));

        }
    }
}
