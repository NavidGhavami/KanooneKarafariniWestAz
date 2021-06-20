using _0_Framework.Application;
using System.Collections.Generic;

namespace ImageGalleryManagement.Application.Contract.PictureGallery
{
    public interface IPictureGalleryApplication
    {
        OperationResult Create(CreatePictureGallery command);
        OperationResult Edit(EditPictureGallery command);
        OperationResult Remove(long id);
        OperationResult Restore(long id);
        EditPictureGallery GetDetails(long id);
        List<PictureGalleryViewModel> GetList();
    }
}
