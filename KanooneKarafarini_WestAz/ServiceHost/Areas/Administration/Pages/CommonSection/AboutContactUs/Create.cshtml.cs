using CommonSectionManagement.Application.Contract.AboutContactUs;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace ServiceHost.Areas.Administration.Pages.CommonSection.AboutContactUs
{
    public class CreateModel : PageModel
    {
        private readonly IAboutContactUsApplication _aboutContactUsApplication;

        public CreateAboutContactUs Command;

        public CreateModel(IAboutContactUsApplication aboutContactUsApplication)
        {
            _aboutContactUsApplication = aboutContactUsApplication;
        }

        public void OnGet()
        {

        }

        public IActionResult OnPost(CreateAboutContactUs command)
        {
            var aboutContact = _aboutContactUsApplication.Create(command);
            return RedirectToPage("./Index");
        }
    }
}
