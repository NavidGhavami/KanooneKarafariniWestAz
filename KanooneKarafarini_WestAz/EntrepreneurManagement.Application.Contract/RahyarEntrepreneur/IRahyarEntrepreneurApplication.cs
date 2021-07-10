using System.Collections.Generic;
using _0_Framework.Application;

namespace EntrepreneurManagement.Application.Contract.RahyarEntrepreneur
{
    public interface IRahyarEntrepreneurApplication
    {
        OperationResult Register(RegisterRahyarEntrepreneur command);
        OperationResult Edit(EditRahyarEntrepreneur command);
        EditRahyarEntrepreneur GetDetails(long id);
        List<RahyarEntrepreneurViewModel> Search(RahyarEntrepreneurSearchModel searchModel);
        RahyarEntrepreneurViewModel GetRahyarEntrepreneurInformationBy(long id);
        string GetResumeBy(long id);
    }
}
