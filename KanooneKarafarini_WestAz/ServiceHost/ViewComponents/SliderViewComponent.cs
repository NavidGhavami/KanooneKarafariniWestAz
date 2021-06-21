using _01_Query.Contract.Slider;
using Microsoft.AspNetCore.Mvc;

namespace ServiceHost.ViewComponents
{
    public class SliderViewComponent : ViewComponent
    {
        private readonly ISliderQuery _sliderQuery;

        public SliderViewComponent(ISliderQuery sliderQuery)
        {
            _sliderQuery = sliderQuery;
        }

        public IViewComponentResult Invoke()
        {
            var slider = _sliderQuery.GetSlider();
            return View(slider);
        }
    }
}
