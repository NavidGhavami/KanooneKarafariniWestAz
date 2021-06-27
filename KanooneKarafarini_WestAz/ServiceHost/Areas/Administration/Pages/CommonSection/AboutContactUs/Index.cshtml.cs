using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CommonSectionManagement.Application.Contract.AboutContactUs;
using CommonSectionManagement.Application.Contract.Footer;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace ServiceHost.Areas.Administration.Pages.CommonSection.AboutContactUs
{
    public class IndexModel : PageModel
    {
        [TempData]
        public string Message { get; set; }

        public List<AboutContactUsViewModel> AboutContact;

        private readonly IAboutContactUsApplication _aboutContactUsApplication;

        public IndexModel(IAboutContactUsApplication aboutContactUsApplication)
        {
            _aboutContactUsApplication = aboutContactUsApplication;

        }

        public void OnGet()
        {

            AboutContact = _aboutContactUsApplication.GetList();
        }


        public IActionResult OnGetRemove(long id)
        {
            var result = _aboutContactUsApplication.Remove(id);

            if (result.IsSuccedded)
            {
                return RedirectToPage("./Index");
            }

            Message = result.Message;
            return RedirectToPage("./Index");

        }
        public IActionResult OnGetRestore(long id)
        {
            var result = _aboutContactUsApplication.Restore(id);
            if (result.IsSuccedded)
            {
                return RedirectToPage("./Index");
            }

            Message = result.Message;
            return RedirectToPage("./Index");
        }
    }
}
