using System.Collections.Generic;
using System.Linq;
using _0_Framework.Application;
using _0_Framework.Infrastructure;
using EntrepreneurManagement.Application.Contract.EntrepreneurServices.EntrepreneurCafe;
using EntrepreneurManagement.Domain.EntrepreneurServices.EntrepreneurCafe;

namespace EntrepreneurManagement.Infrastructure.EFCore.Repository
{
    public class EntrepreneurCafeRepository : RepositoryBase<long,EntrepreneurCafe>, IEntrepreneurCafeRepository
    {
        private readonly EntrepreneurContext _entrepreneurContext;
        public EntrepreneurCafeRepository(EntrepreneurContext entrepreneurContext) : base(entrepreneurContext)
        {
            _entrepreneurContext = entrepreneurContext;
        }

        public EditEntrepreneurCafe GetDetails(long id)
        {
            return _entrepreneurContext.EntrepreneurCafes.Select(x => new EditEntrepreneurCafe
            {
                Id = x.Id,
                CafeName = x.CafeName,
                CafeCity = x.CafeCity,
                CafeManager = x.CafeManager,
                CafeLeader = x.CafeLeader,
                CafeManagerMobile = x.CafeManagerMobile,
                CafeLeaderMobile = x.CafeLeaderMobile

            }).FirstOrDefault(x => x.Id == id);
        }

        public List<EntrepreneurCafeViewModel> Search(EntrepreneurCafeSearchModel searchModel)
        {
            var query = _entrepreneurContext.EntrepreneurCafes
                .Select(x => new EntrepreneurCafeViewModel
                {
                    Id = x.Id,
                    CafeName = x.CafeName,
                    CafeCity = x.CafeCity,
                    CafeManager = x.CafeManager,
                    CafeLeader = x.CafeLeader,
                    CafeManagerMobile = x.CafeManagerMobile,
                    CafeLeaderMobile = x.CafeLeaderMobile,
                    CreationDate = x.CreationDate.ToFarsi()

                });

            if (!string.IsNullOrWhiteSpace(searchModel.CafeName))
            {
                query = query.Where(x => x.CafeName.Contains(searchModel.CafeName));
            }
            if (!string.IsNullOrWhiteSpace(searchModel.CafeCity))
            {
                query = query.Where(x => x.CafeCity.Contains(searchModel.CafeCity));
            }
            if (!string.IsNullOrWhiteSpace(searchModel.CafeManager))
            {
                query = query.Where(x => x.CafeManager.Contains(searchModel.CafeManager));
            }
            if (!string.IsNullOrWhiteSpace(searchModel.CafeLeader))
            {
                query = query.Where(x => x.CafeLeader.Contains(searchModel.CafeLeader));
            }

            return query.OrderByDescending(x => x.Id).ToList();
        }
    }
}
