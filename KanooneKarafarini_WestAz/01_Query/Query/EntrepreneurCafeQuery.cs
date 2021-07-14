using System.Collections.Generic;
using System.Linq;
using _01_Query.Contract.EntrepreneurCafe;
using EntrepreneurManagement.Infrastructure.EFCore;

namespace _01_Query.Query
{
    public class EntrepreneurCafeQuery : IEntrepreneurCafeQuery
    {
        private readonly EntrepreneurContext _entrepreneurContext;

        public EntrepreneurCafeQuery(EntrepreneurContext entrepreneurContext)
        {
            _entrepreneurContext = entrepreneurContext;
        }

        public List<EntrepreneurCafeQueryModel> GetEntrepreneurCafe()
        {
            return _entrepreneurContext.EntrepreneurCafes.Select(x => new EntrepreneurCafeQueryModel
            {
                Id = x.Id,
                CafeName = x.CafeName,
                CafeCity = x.CafeCity,
                CafeManager = x.CafeManager,
                CafeLeader = x.CafeLeader,
                CafeManagerMobile = x.CafeManagerMobile,
                CafeLeaderMobile = x.CafeLeaderMobile,


            }).ToList();
        }
    }
}
