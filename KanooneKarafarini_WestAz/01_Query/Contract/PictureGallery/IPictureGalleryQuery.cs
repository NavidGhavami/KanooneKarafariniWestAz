using System.Collections.Generic;

namespace _01_Query.Contract.PictureGallery
{
    public interface IPictureGalleryQuery
    {
        List<PictureGalleryQueryModel> GetPictureGallery();
    }
}
