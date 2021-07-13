using System.Collections.Generic;
using _0_Framework.Application;

namespace EntrepreneurManagement.Application.Contract.EntrepreneurServices.CounselingCenter
{
    public interface ICounselingCenterApplication
    {
        OperationResult Create(CreateCouncelingCenter command);
        OperationResult Edit(EditCouncelingCenter command);
        EditCouncelingCenter GetDetails(long id);
        CouncelingCenterViewModel GetInformationBy(long id);
        List<CouncelingCenterViewModel> GetList();
        List<CouncelingCenterViewModel> Search(CounselingCenterSearchModel searchModel);


    }
}
