using System.Collections.Generic;
using System.Linq;
using _01_Query.Contract.CounselingCenter;
using _01_Query.Contract.Slider;
using EntrepreneurManagement.Infrastructure.EFCore;

namespace _01_Query.Query
{
    public class CounselingCenterQuery : ICounselingCenterQuery
    {
        private readonly EntrepreneurContext _entrepreneurContext;

        public CounselingCenterQuery(EntrepreneurContext entrepreneurContext)
        {
            _entrepreneurContext = entrepreneurContext;
        }

        public List<CounselingCenterQueryModel> GetCounselingCenter()
        {
            return _entrepreneurContext.CounselingCenters
                .Select(x => new CounselingCenterQueryModel
                {
                    Id = x.Id,
                    CouncelingCenterName = x.CouncelingCenterName,
                    CouncelingCenterActivity = x.CouncelingCenterActivity,
                    ManagerName = x.ManagerName,
                    CouncelingCenterPhone = x.CouncelingCenterPhone,
                    CouncelingCenterMobile = x.CouncelingCenterMobile,
                    CouncelingCenterAddress = x.CouncelingCenterAddress,
                    Description = x.Description

                })
                .ToList();
        }
    }
}
