using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using _01_Query.Contract.AboutContactUs;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace ServiceHost.Pages
{
    public class ContactUsModel : PageModel
    {
        private readonly IAboutContactUsQuery _aboutContactUs;

        public List<AboutContactUsQueryModel> AboutContactUs;

        public ContactUsModel(IAboutContactUsQuery aboutContactUs)
        {
            _aboutContactUs = aboutContactUs;
        }

        public void OnGet()
        {
            AboutContactUs = _aboutContactUs.GetAboutContactUs();
        }
    }
}
