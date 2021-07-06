using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntrepreneurManagement.Application;
using EntrepreneurManagement.Application.Contract.TrueEntrepreneur;
using EntrepreneurManagement.Domain.TrueEntrepreneur;
using EntrepreneurManagement.Infrastructure.EFCore;
using EntrepreneurManagement.Infrastructure.EFCore.Repository;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace EntrepreneurManagement.Configuration
{
    public class EntrepreneurManagementBootstrapper
    {
        public static void Configure(IServiceCollection services, string connectionString)
        {

            services.AddTransient<ITrueEntrepreneurApplication, TrueEntrepreneurApplication>();
            services.AddTransient<ITrueEntrepreneurRepository, TrueEntrepreneurRepository>();





            services.AddDbContext<EntrepreneurContext>(x => x.UseSqlServer(connectionString));

        }
    }
}
