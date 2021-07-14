using System.Collections.Generic;
using _0_Framework.Application;
using EntrepreneurManagement.Application.Contract.EntrepreneurServices.CounselingCenter;

namespace EntrepreneurManagement.Application.Contract.EntrepreneurServices.EntrepreneurCafe
{
    public interface IEntrepreneurCafeApplication
    {
        OperationResult Create(CreateEntrepreneurCafe command);
        OperationResult Edit(EditEntrepreneurCafe command);
        EditEntrepreneurCafe GetDetails(long id);
        List<EntrepreneurCafeViewModel> Search(EntrepreneurCafeSearchModel searchModel);
    }
}
