using System.Collections.Generic;
using _0_Framework.Application;
using EntrepreneurManagement.Application.Contract.BenefactorEntrepreneur;

namespace EntrepreneurManagement.Application.Contract.BenefactorEntrepreneur
{
    public interface IBenefactorEntrepreneurApplication
    {
        OperationResult Register(RegisterBenefactorEntrepreneur command);
        OperationResult Edit(EditBenefactorEntrepreneur command);
        EditBenefactorEntrepreneur GetDetails(long id);
        List<BenefactorEntrepreneurViewModel> Search(BenefactorEntrepreneurSearchModel searchModel);
        BenefactorEntrepreneurViewModel GetBenefactorEntrepreneurInformationBy(long id);
    }
}
