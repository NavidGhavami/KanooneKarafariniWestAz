using System.Collections.Generic;
using _0_Framework.Domain;
using EntrepreneurManagement.Application.Contract.RahyarEntrepreneur;

namespace EntrepreneurManagement.Domain.RahyarEntrepreneur
{
    public interface IRahyarEntrepreneurRepository : IRepository<long, RahyarEntrepreneur>
    {
        EditRahyarEntrepreneur GetDetails(long id);
        List<RahyarEntrepreneurViewModel> Search(RahyarEntrepreneurSearchModel searchModel);
        RahyarEntrepreneurViewModel GetRahyarEntrepreneurInformationBy(long id);
        string GetResumeBy(long id);
    }
}
