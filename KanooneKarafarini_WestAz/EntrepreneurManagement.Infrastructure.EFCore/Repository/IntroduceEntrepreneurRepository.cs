using System.Collections.Generic;
using System.Linq;
using _0_Framework.Application;
using _0_Framework.Infrastructure;
using EntrepreneurManagement.Application.Contract.EntrepreneurServices.IntroduceEntrepreneur;
using EntrepreneurManagement.Domain.EntrepreneurServices.IntroduceEntrepreneur;

namespace EntrepreneurManagement.Infrastructure.EFCore.Repository
{
    public class IntroduceEntrepreneurRepository : RepositoryBase<long, IntroduceEntrepreneur>, IIntroduceEntrepreneurRepository
    {
        private readonly EntrepreneurContext _entrepreneurContext;
        public IntroduceEntrepreneurRepository(EntrepreneurContext entrepreneurContext) : base(entrepreneurContext)
        {
            _entrepreneurContext = entrepreneurContext;
        }

        public EditIntroduceEntrepreneur GetDetails(long id)
        {
            return _entrepreneurContext.IntroduceEntrepreneurs.Select(x => new EditIntroduceEntrepreneur
            {
                Id = x.Id,
                Job = x.Job,
                Fullname = x.Fullname,
                StateTitle = x.StateTitle,
                ResumeDescription = x.ResumeDescription

            }).FirstOrDefault(x => x.Id == id);
        }

        public List<IntroduceEntrepreneurViewModel> Search(IntroduceEntrepreneurSearchModel searchModel)
        {
            var query = _entrepreneurContext.IntroduceEntrepreneurs.Select(x => new IntroduceEntrepreneurViewModel
            {
                Id = x.Id,
                Job = x.Job,
                Photo = x.Photo,
                Fullname = x.Fullname,
                StateTitle = x.StateTitle,
                CreationDate = x.CreationDate.ToFarsi(),
                
            });

            if (!string.IsNullOrWhiteSpace(searchModel.Fullname))
            {
                query = query.Where(x => x.Fullname.Contains(searchModel.Fullname));
            }
            if (!string.IsNullOrWhiteSpace(searchModel.StateTitle))
            {
                query = query.Where(x => x.StateTitle.Contains(searchModel.StateTitle));
            }

            return query.OrderByDescending(x => x.Id).ToList();
        }

        public IntroduceEntrepreneurViewModel GetIntroduceEntrepreneurInformationBy(long id)
        {
            var info = _entrepreneurContext.IntroduceEntrepreneurs.FirstOrDefault(x => x.Id == id);

            if (info == null)
            {
                return new IntroduceEntrepreneurViewModel();
            }

            var information = new IntroduceEntrepreneurViewModel
            {
                Id = info.Id,
                Fullname = info.Fullname,
                Job = info.Job,
                StateTitle = info.StateTitle,
                Photo = info.Photo,
                ResumeDescription = info.ResumeDescription,
                CreationDate = info.CreationDate.ToFarsi()
            };

            return information;
        }

        public string GetResumeBy(long id)
        {
            var resume = _entrepreneurContext.IntroduceEntrepreneurs.FirstOrDefault(x => x.Id == id);

            if (resume == null)
            {
                return new string("");
            }

            return resume.ResumeFile;
        }
    }
}
