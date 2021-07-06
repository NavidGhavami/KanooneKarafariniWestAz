using System.Collections.Generic;
using _0_Framework.Application;

namespace EntrepreneurManagement.Application.Contract.TrueEntrepreneur
{
    public interface ITrueEntrepreneurApplication
    {
        OperationResult Register(RegisterTrueEntrepreneur command);
        OperationResult Edit(EditTrueEntrepreneur command);
        EditTrueEntrepreneur GetDetails(long id);
        List<TrueEntrepreneurViewModel> Search(TrueEntrepreneurSearchModel searchModel);
        TrueEntrepreneurViewModel GetTrueEntrepreneurInformationBy(long id);
        string GetResumeBy(long id);

    }
}
