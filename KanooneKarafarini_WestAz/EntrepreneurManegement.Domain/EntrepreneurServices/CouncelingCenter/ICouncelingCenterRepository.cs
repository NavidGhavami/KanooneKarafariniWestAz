using System.Collections.Generic;
using _0_Framework.Domain;
using EntrepreneurManagement.Application.Contract.EntrepreneurServices.CounselingCenter;

namespace EntrepreneurManagement.Domain.EntrepreneurServices.CouncelingCenter
{
    public interface ICouncelingCenterRepository : IRepository<long, CounselingCenter>
    {
        EditCouncelingCenter GetDetails(long id);
        List<CouncelingCenterViewModel> GetList();
        CouncelingCenterViewModel GetInformationBy(long id);
        List<CouncelingCenterViewModel> Search(CounselingCenterSearchModel searchModel);

    }
}
