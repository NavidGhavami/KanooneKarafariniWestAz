using EntrepreneurManagement.Application.Contract.TrueEntrepreneur;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace ServiceHost.Pages
{
    public class TrueEntrepreneurModel : PageModel
    {
        private readonly ITrueEntrepreneurApplication _trueEntrepreneurApplication;

        public TrueEntrepreneurModel(ITrueEntrepreneurApplication trueEntrepreneurApplication)
        {
            _trueEntrepreneurApplication = trueEntrepreneurApplication;
        }

        public void OnGet()
        {
        }

        public IActionResult OnPost(RegisterTrueEntrepreneur command)
        {

            var result = _trueEntrepreneurApplication.Register(command);
            return RedirectToPage("./SuccessRegister");
        }
    }
}
