using _01_Query.Contract.Partners;
using Microsoft.AspNetCore.Mvc;

namespace ServiceHost.ViewComponents
{
    public class PartnersViewComponent : ViewComponent
    {
        private readonly IPartnerQuery _partnerQuery;

        public PartnersViewComponent(IPartnerQuery partnerQuery)
        {
            _partnerQuery = partnerQuery;
        }

        public IViewComponentResult Invoke()
        {
            var partner = _partnerQuery.GetPartners();
            return View(partner);
        }
    }
}
