using Microsoft.AspNetCore.Mvc;

namespace ServiceHost.ViewComponents
{
    public class BannersViewComponent : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
