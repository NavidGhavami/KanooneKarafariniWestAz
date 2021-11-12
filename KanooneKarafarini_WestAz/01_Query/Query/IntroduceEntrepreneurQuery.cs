using System.Collections.Generic;
using System.Linq;
using _01_Query.Contract.IntroduceEntrepreneur;
using EntrepreneurManagement.Infrastructure.EFCore;

namespace _01_Query.Query
{
    public class IntroduceEntrepreneurQuery : IIntroduceEntrepreneurQuery
    {
        private readonly EntrepreneurContext _entrepreneurContext;

        public IntroduceEntrepreneurQuery(EntrepreneurContext entrepreneurContext)
        {
            _entrepreneurContext = entrepreneurContext;
        }

        public List<IntroduceEntrepreneurQueryModel> GetIntroduceEntrepreneur()
        {
            return _entrepreneurContext.IntroduceEntrepreneurs.Select(x => new IntroduceEntrepreneurQueryModel
            {
                Id = x.Id,
                Fullname = x.Fullname,
                Job = x.Job,
                Photo = x.Photo,
                StateTitle = x.StateTitle,
                ResumeDescription = x.ResumeDescription

            }).ToList();
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
