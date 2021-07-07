using System.Collections.Generic;
using _0_Framework.Application;

namespace EntrepreneurManagement.Application.Contract.LegalEntrepreneur
{
    public interface ILegalEntrepreneurApplication
    {
        OperationResult Register(RegisterLegalEntrepreneur command);
        OperationResult Edit(EditLegalEntrepreneur command);
        EditLegalEntrepreneur GetDetails(long id);
        List<LegalEntrepreneurViewModel> Search(LegalEntrepreneurSearchModel searchModel);
        LegalEntrepreneurViewModel GetLegalEntrepreneurInformationBy(long id);
        string GetResumeBy(long id);
    }
}
