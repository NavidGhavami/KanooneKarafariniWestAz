using System.Collections.Generic;

namespace _01_Query.Contract.Partners
{
    public interface IPartnerQuery
    {
        List<PartnersQueryModel> GetPartners();

    }
}
