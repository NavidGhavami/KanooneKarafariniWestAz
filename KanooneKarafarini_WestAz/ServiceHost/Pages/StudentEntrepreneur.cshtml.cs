using EntrepreneurManagement.Application.Contract.StudentEntrepreneur;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace ServiceHost.Pages
{
    public class StudentEntrepreneurModel : PageModel
    {
        private readonly IStudentEntrepreneurApplication _studentEntrepreneurApplication;

        public StudentEntrepreneurModel(IStudentEntrepreneurApplication studentEntrepreneurApplication)
        {
            _studentEntrepreneurApplication = studentEntrepreneurApplication;
        }

        public void OnGet()
        {
        }

        public IActionResult OnPost(RegisterStudentEntrepreneur command)
        {

            var result = _studentEntrepreneurApplication.Register(command);
            return RedirectToPage("./SuccessRegister");
        }
    }
}
