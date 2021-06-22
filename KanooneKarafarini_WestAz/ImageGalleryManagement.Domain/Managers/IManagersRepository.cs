using System.Collections.Generic;
using _0_Framework.Domain;
using ImageGalleryManagement.Application.Contract.Managers;

namespace ImageGalleryManagement.Domain.Managers
{
    public interface IManagersRepository : IRepository<long, Managers>
    {
        EditManagers GetDetails(long id);
        List<ManagersViewModel> GetList();
    }
}
