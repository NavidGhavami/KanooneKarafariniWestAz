using System.Collections.Generic;
using _0_Framework.Domain;
using EntrepreneurManagement.Application.Contract.BenefactorEntrepreneur;

namespace EntrepreneurManagement.Domain.BenefactorEntrepreneur
{
    public interface IBenefactorEntrepreneurRepository : IRepository<long, BenefactorEntrepreneur>
    {
        EditBenefactorEntrepreneur GetDetails(long id);
        List<BenefactorEntrepreneurViewModel> Search(BenefactorEntrepreneurSearchModel searchModel);
        BenefactorEntrepreneurViewModel GetBenefactorEntrepreneurInformationBy(long id);
    }
}
