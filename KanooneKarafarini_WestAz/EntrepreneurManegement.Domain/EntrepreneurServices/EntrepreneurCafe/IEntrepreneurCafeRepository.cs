using System.Collections.Generic;
using _0_Framework.Domain;
using EntrepreneurManagement.Application.Contract.EntrepreneurServices.EntrepreneurCafe;

namespace EntrepreneurManagement.Domain.EntrepreneurServices.EntrepreneurCafe
{
    public interface IEntrepreneurCafeRepository : IRepository<long, EntrepreneurCafe>
    {
        EditEntrepreneurCafe GetDetails(long id);
        List<EntrepreneurCafeViewModel> Search(EntrepreneurCafeSearchModel searchModel);
    }
}
