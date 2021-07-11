using EntrepreneurManagement.Application.Contract.BenefactorEntrepreneur;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace ServiceHost.Pages
{
    public class BenefactorEntrepreneurModel : PageModel
    {
        private readonly IBenefactorEntrepreneurApplication _benefactorEntrepreneurApplication;

        public BenefactorEntrepreneurModel(IBenefactorEntrepreneurApplication benefactorEntrepreneurApplication)
        {
            _benefactorEntrepreneurApplication = benefactorEntrepreneurApplication;
        }

        public void OnGet()
        {
        }

        public IActionResult OnPost(RegisterBenefactorEntrepreneur command)
        {

            var result = _benefactorEntrepreneurApplication.Register(command);
            return RedirectToPage("./SuccessRegister");
        }
    }
}
