using System.Collections.Generic;
using System.Linq;
using _01_Query.Contract.Managers;
using ImageGalleryManagement.Infrastructure.EFCore;

namespace _01_Query.Query
{
    public class ManagerQuery : IManagerQuery
    {
        private readonly ImageGalleryContext _imageGalleryContext;

        public ManagerQuery(ImageGalleryContext imageGalleryContext)
        {
            _imageGalleryContext = imageGalleryContext;
        }

        public List<ManagerQueryModel> GetManager()
        {
            return _imageGalleryContext.Managers
                .Where(x => x.IsRemoved == false)
                .Select(x => new ManagerQueryModel
                {
                    Fullname = x.Fullname,
                    JobPosition = x.JobPosition,
                    OrganizationType = x.OrganizationType,
                    Email = x.Email,
                    Phone = x.Phone,
                    Mobile = x.Mobile,
                    Picture = x.Picture,
                    PictureAlt = x.PictureAlt,
                    PictureTitle = x.PictureTitle,
                    

                }).ToList();
        }
    }
}
