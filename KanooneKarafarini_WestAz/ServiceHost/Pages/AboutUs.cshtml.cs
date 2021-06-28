using System.Collections.Generic;
using _01_Query.Contract.AboutContactUs;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace ServiceHost.Pages
{
    public class AboutUsModel : PageModel
    {
        private readonly IAboutContactUsQuery _aboutContactUs;

        public List<AboutContactUsQueryModel> AboutContactUs;

        public AboutUsModel(IAboutContactUsQuery aboutContactUs)
        {
            _aboutContactUs = aboutContactUs;
        }

        public void OnGet()
        {
            AboutContactUs = _aboutContactUs.GetAboutContactUs();
        }
    }
}
