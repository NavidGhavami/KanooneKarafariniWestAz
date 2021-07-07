using System.Collections.Generic;
using _0_Framework.Domain;
using EntrepreneurManagement.Application.Contract.LegalEntrepreneur;

namespace EntrepreneurManagement.Domain.LegalEntrepreneur
{
    public interface ILegalEntrepreneurRepository : IRepository<long, LegalEntrepreneur>
    {
        EditLegalEntrepreneur GetDetails(long id);
        List<LegalEntrepreneurViewModel> Search(LegalEntrepreneurSearchModel searchModel);
        LegalEntrepreneurViewModel GetLegalEntrepreneurInformationBy(long id);
        string GetResumeBy(long id);
    }

    
}
