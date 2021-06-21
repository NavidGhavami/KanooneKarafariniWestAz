using _01_Query.Contract.Slider;
using ImageGalleryManagement.Infrastructure.EFCore;
using System.Collections.Generic;
using System.Linq;

namespace _01_Query.Query
{
    public class SliderQuery : ISliderQuery
    {
        private readonly ImageGalleryContext _imageGalleryContext;

        public SliderQuery(ImageGalleryContext imageGalleryContext)
        {
            _imageGalleryContext = imageGalleryContext;
        }

        public List<SliderQueryModel> GetSlider()
        {
            return _imageGalleryContext.Sliders
                .Where(x => x.IsRemoved == false)
                .Select(x => new SliderQueryModel
                {
                    Picture = x.Picture,
                    PictureAlt = x.PictureAlt,
                    PictureTitle = x.PictureTitle,
                    UrlLink = x.UrlLink,
                    Title = x.Title,

                })
                .ToList();
        }
    }
}
