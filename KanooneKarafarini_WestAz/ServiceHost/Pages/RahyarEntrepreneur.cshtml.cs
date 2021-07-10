using EntrepreneurManagement.Application.Contract.RahyarEntrepreneur;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace ServiceHost.Pages
{
    public class RahyarEntrepreneurModel : PageModel
    {
        private readonly IRahyarEntrepreneurApplication _rahyarEntrepreneurApplication;

        public RahyarEntrepreneurModel(IRahyarEntrepreneurApplication rahyarEntrepreneurApplication)
        {
            _rahyarEntrepreneurApplication = rahyarEntrepreneurApplication;
            
        }

        public void OnGet()
        {
        }

        public IActionResult OnPost(RegisterRahyarEntrepreneur command)
        {

            var result = _rahyarEntrepreneurApplication.Register(command);
            return RedirectToPage("./SuccessRegister");
        }
    }
}
