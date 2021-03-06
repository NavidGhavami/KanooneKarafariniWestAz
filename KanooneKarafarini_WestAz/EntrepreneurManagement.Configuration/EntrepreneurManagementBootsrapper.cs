using _01_Query.Contract.CounselingCenter;
using _01_Query.Contract.EntrepreneurCafe;
using _01_Query.Contract.IntroduceArticle;
using _01_Query.Contract.IntroduceEntrepreneur;
using _01_Query.Query;
using EntrepreneurManagement.Application;
using EntrepreneurManagement.Application.Contract.BenefactorEntrepreneur;
using EntrepreneurManagement.Application.Contract.EntrepreneurServices.CounselingCenter;
using EntrepreneurManagement.Application.Contract.EntrepreneurServices.EntrepreneurCafe;
using EntrepreneurManagement.Application.Contract.EntrepreneurServices.IntroduceArticle;
using EntrepreneurManagement.Application.Contract.EntrepreneurServices.IntroduceEntrepreneur;
using EntrepreneurManagement.Application.Contract.EntrepreneurServices.SubmitIdea;
using EntrepreneurManagement.Application.Contract.LegalEntrepreneur;
using EntrepreneurManagement.Application.Contract.RahyarEntrepreneur;
using EntrepreneurManagement.Application.Contract.StudentEntrepreneur;
using EntrepreneurManagement.Application.Contract.TrueEntrepreneur;
using EntrepreneurManagement.Domain.BenefactorEntrepreneur;
using EntrepreneurManagement.Domain.EntrepreneurServices.CouncelingCenter;
using EntrepreneurManagement.Domain.EntrepreneurServices.EntrepreneurCafe;
using EntrepreneurManagement.Domain.EntrepreneurServices.IntroduceArticle;
using EntrepreneurManagement.Domain.EntrepreneurServices.IntroduceEntrepreneur;
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

            services.AddTransient<IEntrepreneurCafeApplication, EntrepreneurCafeApplication>();
            services.AddTransient<IEntrepreneurCafeRepository, EntrepreneurCafeRepository>();

            services.AddTransient<IIntroduceEntrepreneurApplication, IntroduceEntrepreneurApplication>();
            services.AddTransient<IIntroduceEntrepreneurRepository, IntroduceEntrepreneurRepository>();

            services.AddTransient<IIntroduceArticleApplication, IntroduceArticleApplication>();
            services.AddTransient<IIntroduceArticleRepository, IntroduceArticleRepository>();



            services.AddTransient<ICounselingCenterQuery, CounselingCenterQuery>();
            services.AddTransient<IEntrepreneurCafeQuery, EntrepreneurCafeQuery>();
            services.AddTransient<IIntroduceEntrepreneurQuery, IntroduceEntrepreneurQuery>();
            services.AddTransient<IIntroduceArticleQuery, IntroduceArticleQuery>();



            services.AddDbContext<EntrepreneurContext>(x => x.UseSqlServer(connectionString));

        }
    }
}
