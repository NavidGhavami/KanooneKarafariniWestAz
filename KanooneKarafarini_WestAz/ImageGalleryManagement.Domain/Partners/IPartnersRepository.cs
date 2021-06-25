using System.Collections.Generic;
using _0_Framework.Domain;
using ImageGalleryManagement.Application.Contract.Partners;

namespace ImageGalleryManagement.Domain.Partners
{
    public interface IPartnersRepository : IRepository<long , Partners>
    {
        EditPartners GetDetails(long id);
        List<PartnersViewModel> GetList();
    }
}
