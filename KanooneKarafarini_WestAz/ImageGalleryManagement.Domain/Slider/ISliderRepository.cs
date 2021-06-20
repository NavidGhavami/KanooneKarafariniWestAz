using _0_Framework.Domain;
using ImageGalleryManagement.Application.Contract.Slider;
using System.Collections.Generic;

namespace ImageGalleryManagement.Domain.Slider
{
    public interface ISliderRepository : IRepository<long, Slider>
    {
        EditSlider GetDetails(long id);
        List<SliderViewModel> GetList();
    }
}
