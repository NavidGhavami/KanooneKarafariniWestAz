using _0_Framework.Application;
using _0_Framework.Infrastructure;
using ImageGalleryManagement.Application.Contract.PictureGallery;
using ImageGalleryManagement.Domain.PictureGallery;
using ShopManagement.Infrastructure.EFCore;
using System.Collections.Generic;
using System.Linq;

namespace ImageGalleryManagement.EFCore.Repository
{
    public class PictureGalleryRepository : RepositoryBase<long, PictureGallery>, IPictureGalleryRepository
    {
        private readonly ImageGalleryContext _context;

        public PictureGalleryRepository(ImageGalleryContext context) : base(context)
        {
            _context = context;
        }


        public EditPictureGallery GetDetails(long id)
        {
            return _context.PictureGalleries.Select(x => new EditPictureGallery
            {
                Id = x.Id,
                //Picture = x.Picture,
                PictureTitle = x.PictureTitle,
                PictureAlt = x.PictureAlt,

            }).FirstOrDefault(x => x.Id == id);
        }

        public List<PictureGalleryViewModel> GetList()
        {
            return _context.PictureGalleries.Select(x => new PictureGalleryViewModel
            {
                Id = x.Id,
                Picture = x.Picture,
                IsRemoved = x.IsRemoved,
                CreationDate = x.CreationDate.ToFarsi()


            }).OrderByDescending(x => x.Id).ToList();
        }
    }

}
