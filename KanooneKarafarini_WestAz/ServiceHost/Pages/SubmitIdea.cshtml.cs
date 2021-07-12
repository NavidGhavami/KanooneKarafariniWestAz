using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EntrepreneurManagement.Application.Contract.EntrepreneurServices.SubmitIdea;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace ServiceHost.Pages
{
    public class SubmitIdeaModel : PageModel
    {
        private readonly ISubmitIdeaApplication _submitIdeaApplication;

        public SubmitIdeaModel(ISubmitIdeaApplication submitIdeaApplication)
        {
            _submitIdeaApplication = submitIdeaApplication;
        }


        public IActionResult OnPost(CreateSubmitIdea command)
        {

            var result = _submitIdeaApplication.Create(command);
            return RedirectToPage("./SuccessRegister");
        }
    }
}
