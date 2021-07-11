using System.Collections.Generic;
using EntrepreneurManagement.Application.Contract.BenefactorEntrepreneur;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace ServiceHost.Areas.Administration.Pages.Entrepreneur.BenefactorEntrepreneur
{
    public class IndexModel : PageModel
    {
        [TempData]
        public string Message { get; set; }

        public List<BenefactorEntrepreneurViewModel> BenefactorEntrepreneur;
        public BenefactorEntrepreneurSearchModel SearchModel;

        private readonly IBenefactorEntrepreneurApplication _benefactorEntrepreneurApplication;
        private readonly IWebHostEnvironment _webHostEnvironment;


        public IndexModel(IBenefactorEntrepreneurApplication benefactorEntrepreneurApplication, IWebHostEnvironment webHostEnvironment)
        {
            _benefactorEntrepreneurApplication = benefactorEntrepreneurApplication;
            _webHostEnvironment = webHostEnvironment;
        }


        public void OnGet(BenefactorEntrepreneurSearchModel searchModel)
        {

            BenefactorEntrepreneur = _benefactorEntrepreneurApplication.Search(searchModel);
        }


        public IActionResult OnGetEdit(long id)
        {
            var benefactorEntrepreneur = _benefactorEntrepreneurApplication.GetDetails(id);
            return Partial("Edit", benefactorEntrepreneur);
        }

        public JsonResult OnPostEdit(EditBenefactorEntrepreneur command)
        {
            var result = _benefactorEntrepreneurApplication.Edit(command);
            return new JsonResult(result);
        }

        public IActionResult OnGetGetInformation(long id)
        {
            var info = _benefactorEntrepreneurApplication.GetBenefactorEntrepreneurInformationBy(id);
            return Partial("Information", info);
        }
    }
}
