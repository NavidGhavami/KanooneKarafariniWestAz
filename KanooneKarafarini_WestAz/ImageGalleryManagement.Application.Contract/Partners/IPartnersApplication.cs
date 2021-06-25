using System.Collections.Generic;
using _0_Framework.Application;

namespace ImageGalleryManagement.Application.Contract.Partners
{
    public interface IPartnersApplication
    {
        OperationResult Create(CreatePartners command);
        OperationResult Edit(EditPartners command);
        OperationResult Remove(long id);
        OperationResult Restore(long id);
        EditPartners GetDetails(long id);
        List<PartnersViewModel> GetList();
    }
}
