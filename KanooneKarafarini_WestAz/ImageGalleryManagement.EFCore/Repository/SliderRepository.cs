using System.Collections.Generic;
using System.Linq;
using _0_Framework.Application;
using _0_Framework.Infrastructure;
using ImageGalleryManagement.Application.Contract.Slider;
using ImageGalleryManagement.Domain.Slider;
using ShopManagement.Infrastructure.EFCore;

namespace ImageGalleryManagement.Infrastructure.EFCore.Repository
{
    public class SliderRepository : RepositoryBase<long, Slider>, ISliderRepository
    {
        private readonly ImageGalleryContext _context;

        public SliderRepository(ImageGalleryContext context) : base(context)
        {
            _context = context;
        }

        public EditSlider GetDetails(long id)
        {
            return _context.Sliders.Select(x => new EditSlider
            {
                Id = x.Id,
                //Picture = x.Picture,
                PictureTitle = x.PictureTitle,
                PictureAlt = x.PictureAlt,
                Title = x.Title,
                UrlLink = x.UrlLink

            }).FirstOrDefault(x => x.Id == id);
        }

        public List<SliderViewModel> GetList()
        {

            return _context.Sliders.Select(x => new SliderViewModel
            {
                Id = x.Id,
                Picture = x.Picture,
                Title = x.Title,
                IsRemoved = x.IsRemoved,
                CreationDate = x.CreationDate.ToFarsi()


            }).OrderByDescending(x => x.Id).ToList();
        }
    }
}
