using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using _01_Query.Contract.Footer;
using Microsoft.AspNetCore.Mvc;

namespace ServiceHost.ViewComponents
{
    public class FooterViewComponent : ViewComponent
    {
        private readonly IFooterQuery _footerQuery;

        public FooterViewComponent(IFooterQuery footerQuery)
        {
            _footerQuery = footerQuery;
        }

        public IViewComponentResult Invoke()
        {
            var footer = _footerQuery.GetFooter();
            return View(footer);
        }
    }
}
