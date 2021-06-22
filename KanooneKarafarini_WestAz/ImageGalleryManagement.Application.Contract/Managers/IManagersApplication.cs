using System.Collections.Generic;
using _0_Framework.Application;
using ImageGalleryManagement.Application.Contract.Slider;

namespace ImageGalleryManagement.Application.Contract.Managers
{
    public interface IManagersApplication
    {
        OperationResult Create(CreateManagers command);
        OperationResult Edit(EditManagers command);
        OperationResult Remove(long id);
        OperationResult Restore(long id);
        EditManagers GetDetails(long id);
        List<ManagersViewModel> GetList();
    }
}
