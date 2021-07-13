using System.Collections.Generic;
using System.Linq;
using _0_Framework.Application;
using _0_Framework.Infrastructure;
using EntrepreneurManagement.Application.Contract.EntrepreneurServices.CounselingCenter;
using EntrepreneurManagement.Domain.EntrepreneurServices.CouncelingCenter;
using Microsoft.EntityFrameworkCore;

namespace EntrepreneurManagement.Infrastructure.EFCore.Repository
{
    public class CouncelingCenterRepository : RepositoryBase<long, CounselingCenter>, ICouncelingCenterRepository
    {
        private readonly EntrepreneurContext _entrepreneurContext;
        public CouncelingCenterRepository(EntrepreneurContext entrepreneurContext) : base(entrepreneurContext)
        {
            _entrepreneurContext = entrepreneurContext;
        }

        public EditCouncelingCenter GetDetails(long id)
        {
            return _entrepreneurContext.CounselingCenters.Select(x => new EditCouncelingCenter
            {
                Id=x.Id,
                CouncelingCenterName = x.CouncelingCenterName,
                CouncelingCenterActivity = x.CouncelingCenterActivity,
                ManagerName = x.ManagerName,
                CouncelingCenterPhone = x.CouncelingCenterPhone,
                CouncelingCenterMobile = x.CouncelingCenterMobile,
                CouncelingCenterAddress = x.CouncelingCenterAddress,
                Description = x.Description


            }).FirstOrDefault(x => x.Id == id);
        }

        public List<CouncelingCenterViewModel> GetList()
        {
            return _entrepreneurContext.CounselingCenters.Select(x => new CouncelingCenterViewModel
            {
                Id = x.Id,
                CouncelingCenterName = x.CouncelingCenterName,
                CouncelingCenterActivity = x.CouncelingCenterActivity,
                ManagerName = x.ManagerName,
                CouncelingCenterPhone = x.CouncelingCenterPhone,
                CouncelingCenterMobile = x.CouncelingCenterMobile,
                CouncelingCenterAddress = x.CouncelingCenterAddress,
                Description = x.Description,
                CreationDate =x.CreationDate.ToFarsi()




            }).OrderByDescending(x => x.Id).ToList();
        }

        public CouncelingCenterViewModel GetInformationBy(long id)
        {
            return _entrepreneurContext.CounselingCenters.Select(x => new CouncelingCenterViewModel
            {
                Id = x.Id,
                CouncelingCenterName = x.CouncelingCenterName,
                CouncelingCenterActivity = x.CouncelingCenterActivity,
                ManagerName = x.ManagerName,
                CouncelingCenterPhone = x.CouncelingCenterPhone,
                CouncelingCenterMobile = x.CouncelingCenterMobile,
                CouncelingCenterAddress = x.CouncelingCenterAddress,
                Description = x.Description,
                CreationDate = x.CreationDate.ToFarsi()

            }).FirstOrDefault(x => x.Id == id);
        }

        public List<CouncelingCenterViewModel> Search(CounselingCenterSearchModel searchModel)
        {
            var query = _entrepreneurContext.CounselingCenters
                .Select(x => new CouncelingCenterViewModel
                {
                    Id = x.Id,
                    CouncelingCenterName = x.CouncelingCenterName,
                    CouncelingCenterActivity = x.CouncelingCenterActivity,
                    ManagerName = x.ManagerName,
                    CouncelingCenterPhone = x.CouncelingCenterPhone,
                    CouncelingCenterMobile = x.CouncelingCenterMobile,
                    CouncelingCenterAddress = x.CouncelingCenterAddress,
                    Description = x.Description,
                    CreationDate = x.CreationDate.ToFarsi()

                });

            if (!string.IsNullOrWhiteSpace(searchModel.CouncelingCenterName))
            {
                query = query.Where(x => x.CouncelingCenterName.Contains(searchModel.CouncelingCenterName));
            }
            if (!string.IsNullOrWhiteSpace(searchModel.ManagerName))
            {
                query = query.Where(x => x.ManagerName.Contains(searchModel.ManagerName));
            }
            if (!string.IsNullOrWhiteSpace(searchModel.CouncelingCenterMobile))
            {
                query = query.Where(x => x.CouncelingCenterMobile.Contains(searchModel.CouncelingCenterMobile));
            }

            return query.OrderByDescending(x => x.Id).ToList();
        }
    }
}
