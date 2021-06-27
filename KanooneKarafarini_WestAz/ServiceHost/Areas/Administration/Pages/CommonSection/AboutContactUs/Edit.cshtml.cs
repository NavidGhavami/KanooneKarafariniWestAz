using CommonSectionManagement.Application.Contract.AboutContactUs;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace ServiceHost.Areas.Administration.Pages.CommonSection.AboutContactUs
{
    public class EditModel : PageModel
    {
        public EditAboutContactUs Command;

        private readonly IAboutContactUsApplication _aboutContactUsApplication;

        public EditModel(IAboutContactUsApplication aboutContactUsApplication)
        {
            _aboutContactUsApplication = aboutContactUsApplication;
        }

        public void OnGet(long id)
        {
            Command = _aboutContactUsApplication.GetDetails(id);
        }
        public IActionResult OnPost(EditAboutContactUs command)
        {
            var aboutContact = _aboutContactUsApplication.Edit(command);
            return RedirectToPage("./Index");
        }
    }
}
