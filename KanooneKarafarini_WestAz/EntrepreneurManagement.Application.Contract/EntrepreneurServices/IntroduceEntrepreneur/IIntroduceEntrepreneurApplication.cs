using System.Collections.Generic;
using _0_Framework.Application;

namespace EntrepreneurManagement.Application.Contract.EntrepreneurServices.IntroduceEntrepreneur
{
    public interface IIntroduceEntrepreneurApplication
    {
        OperationResult Create(CreateIntroduceEntrepreneur command);
        OperationResult Edit(EditIntroduceEntrepreneur command);
        EditIntroduceEntrepreneur GetDetails(long id);
        List<IntroduceEntrepreneurViewModel> Search(IntroduceEntrepreneurSearchModel searchModel);
        IntroduceEntrepreneurViewModel GetIntroduceEntrepreneurInformationBy(long id);
        string GetResumeBy(long id);
    }
}
