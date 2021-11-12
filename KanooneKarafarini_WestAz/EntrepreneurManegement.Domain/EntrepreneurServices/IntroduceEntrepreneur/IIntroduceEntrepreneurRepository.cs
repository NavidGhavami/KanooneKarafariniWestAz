using System.Collections.Generic;
using _0_Framework.Domain;
using EntrepreneurManagement.Application.Contract.EntrepreneurServices.IntroduceEntrepreneur;

namespace EntrepreneurManagement.Domain.EntrepreneurServices.IntroduceEntrepreneur
{
    public interface IIntroduceEntrepreneurRepository : IRepository<long, IntroduceEntrepreneur>
    {
        EditIntroduceEntrepreneur GetDetails(long id);
        List<IntroduceEntrepreneurViewModel> Search(IntroduceEntrepreneurSearchModel searchModel);
        IntroduceEntrepreneurViewModel GetIntroduceEntrepreneurInformationBy(long id);
        string GetResumeBy(long id);
    }
}
