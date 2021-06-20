using _0_Framework.Domain;
using ImageGalleryManagement.Application.Contract.PictureGallery;
using System.Collections.Generic;

namespace ImageGalleryManagement.Domain.PictureGallery
{
    public interface IPictureGalleryRepository : IRepository<long, PictureGallery>
    {
        EditPictureGallery GetDetails(long id);
        List<PictureGalleryViewModel> GetList();
    }
}
