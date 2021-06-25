using Microsoft.AspNetCore.Mvc;

namespace ServiceHost.ViewComponents
{
    public class Representatives_PartnersViewComponent : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
