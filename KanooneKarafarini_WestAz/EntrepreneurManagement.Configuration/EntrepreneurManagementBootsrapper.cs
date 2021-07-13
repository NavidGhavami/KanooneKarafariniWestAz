using _01_Query.Contract.CounselingCenter;
using _01_Query.Query;
using EntrepreneurManagement.Application;
using EntrepreneurManagement.Application.Contract.BenefactorEntrepreneur;
using EntrepreneurManagement.Application.Contract.EntrepreneurServices.CounselingCenter;
using EntrepreneurManagement.Application.Contract.EntrepreneurServices.SubmitIdea;
using EntrepreneurManagement.Application.Contract.LegalEntrepreneur;
using EntrepreneurManagement.Application.Contract.RahyarEntrepreneur;
using EntrepreneurManagement.Application.Contract.StudentEntrepreneur;
using EntrepreneurManagement.Application.Contract.TrueEntrepreneur;
using EntrepreneurManagement.Domain.BenefactorEntrepreneur;
using EntrepreneurManagement.Domain.EntrepreneurServices.CouncelingCenter;
using EntrepreneurManagement.Domain.EntrepreneurServices.SubmitIdea;
using EntrepreneurManagement.Domain.LegalEntrepreneur;
using EntrepreneurManagement.Domain.RahyarEntrepreneur;
using EntrepreneurManagement.Domain.StudentEntrepreneur;
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

            services.AddTransient<ILegalEntrepreneurApplication, LegalEntrepreneurApplication>();
            services.AddTransient<ILegalEntrepreneurRepository, LegalEntrepreneurRepository>();

            services.AddTransient<IStudentEntrepreneurApplication, StudentEntrepreneurApplication>();
            services.AddTransient<IStudentEntrepreneurRepository, StudentEntrepreneurRepository>();

            services.AddTransient<IRahyarEntrepreneurApplication, RahyarEntrepreneurApplication>();
            services.AddTransient<IRahyarEntrepreneurRepository, RahyarEntrepreneurRepository>();

            services.AddTransient<IBenefactorEntrepreneurApplication, BenefactorEntrepreneurApplication>();
            services.AddTransient<IBenefactorEntrepreneurRepository, BenefactorEntrepreneurRepository>();

            services.AddTransient<ISubmitIdeaApplication, SubmitIdeaApplication>();
            services.AddTransient<ISubmitIdeaRepository, SubmitIdeaRepository>();

            services.AddTransient<ICounselingCenterApplication, CounselingCenterApplication>();
            services.AddTransient<ICouncelingCenterRepository, CouncelingCenterRepository>();


            services.AddTransient<ICounselingCenterQuery, CounselingCenterQuery>();



            services.AddDbContext<EntrepreneurContext>(x => x.UseSqlServer(connectionString));

        }
    }
}
