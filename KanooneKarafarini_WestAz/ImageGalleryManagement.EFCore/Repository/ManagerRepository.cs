using System.Collections.Generic;
using System.Linq;
using _0_Framework.Application;
using _0_Framework.Infrastructure;
using ImageGalleryManagement.Application.Contract.Managers;
using ImageGalleryManagement.Domain.Managers;
using ImageGalleryManagement.Infrastructure.EFCore;

namespace ImageGalleryManagement.EFCore.Repository
{
    public class ManagerRepository : RepositoryBase<long, Managers>, IManagersRepository
    {
        private readonly ImageGalleryContext _context;
        public ManagerRepository( ImageGalleryContext context) : base(context)
        {
            _context = context;
        }

        public EditManagers GetDetails(long id)
        {
            return _context.Managers.Select(x => new EditManagers
            {
                Id = x.Id,
                Fullname = x.Fullname,
                PictureAlt = x.PictureAlt,
                PictureTitle = x.PictureTitle,
                JobPosition = x.JobPosition,
                OrganizationType = x.OrganizationType,
                Email = x.Email,
                Phone = x.Phone,
                Mobile = x.Mobile

            }).FirstOrDefault(x => x.Id == id);
        }

        public List<ManagersViewModel> GetList()
        {
            return _context.Managers.Select(x => new ManagersViewModel
            {
                Id = x.Id,
                Fullname = x.Fullname,
                Picture = x.Picture,
                JobPosition = x.JobPosition,
                OrganizationType = x.OrganizationType,
                Mobile = x.Mobile,
                IsRemoved = x.IsRemoved,
                CreationDate = x.CreationDate.ToFarsi()

            }).OrderByDescending(x=>x.Id).ToList();
        }
    }
}
