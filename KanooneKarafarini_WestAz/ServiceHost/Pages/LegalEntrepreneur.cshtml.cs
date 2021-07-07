using EntrepreneurManagement.Application.Contract.LegalEntrepreneur;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace ServiceHost.Pages
{
    public class LegalEntrepreneurModel : PageModel
    {
        private readonly ILegalEntrepreneurApplication _legalEntrepreneurApplication;

        public LegalEntrepreneurModel(ILegalEntrepreneurApplication legalEntrepreneurApplication)
        {
            _legalEntrepreneurApplication = legalEntrepreneurApplication;
        }

        public void OnGet()
        {
        }

        public IActionResult OnPost(RegisterLegalEntrepreneur command)
        {

            var result = _legalEntrepreneurApplication.Register(command);
            return RedirectToPage("./SuccessRegister");
        }
    }
}
