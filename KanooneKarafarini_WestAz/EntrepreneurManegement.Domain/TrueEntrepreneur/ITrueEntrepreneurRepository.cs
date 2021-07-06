using System.Collections.Generic;
using _0_Framework.Domain;
using EntrepreneurManagement.Application.Contract.TrueEntrepreneur;

namespace EntrepreneurManagement.Domain.TrueEntrepreneur
{
    public interface ITrueEntrepreneurRepository : IRepository<long, TrueEntrepreneur>
    {
        EditTrueEntrepreneur GetDetails(long id);
        List<TrueEntrepreneurViewModel> Search(TrueEntrepreneurSearchModel searchModel);
        TrueEntrepreneurViewModel GetTrueEntrepreneurInformationBy(long id);
        string GetResumeBy(long id);

    }
}
