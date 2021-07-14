using _01_Query.Contract.PictureGallery;
using ImageGalleryManagement.Infrastructure.EFCore;
using System.Collections.Generic;
using System.Linq;

namespace _01_Query.Query
{
    public class PictureGalleryQuery : IPictureGalleryQuery
    {
        private readonly ImageGalleryContext _imageGalleryContext;

        public PictureGalleryQuery(ImageGalleryContext imageGalleryContext)
        {
            _imageGalleryContext = imageGalleryContext;
        }

        public List<PictureGalleryQueryModel> GetPictureGallery()
        {
            return _imageGalleryContext.PictureGalleries
                .Where(x => x.IsRemoved == false)
                .Select(x => new PictureGalleryQueryModel
                {
                    Picture = x.Picture,
                    PictureAlt = x.PictureAlt,
                    PictureTitle = x.PictureTitle,
                }).ToList();
        }
    }
}
