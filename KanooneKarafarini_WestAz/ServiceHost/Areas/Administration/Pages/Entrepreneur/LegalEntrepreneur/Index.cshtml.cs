using System.Collections.Generic;
using System.IO;
using EntrepreneurManagement.Application.Contract.LegalEntrepreneur;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace ServiceHost.Areas.Administration.Pages.Entrepreneur.LegalEntrepreneur
{
    public class IndexModel : PageModel
    {
        [TempData]
        public string Message { get; set; }

        public List<LegalEntrepreneurViewModel> LegalEntrepreneur;
        public LegalEntrepreneurSearchModel SearchModel;

        private readonly ILegalEntrepreneurApplication _legalEntrepreneurApplication;
        private readonly IWebHostEnvironment _webHostEnvironment;

        public IndexModel(ILegalEntrepreneurApplication legalEntrepreneurApplication, IWebHostEnvironment webHostEnvironment)
        {
            _legalEntrepreneurApplication = legalEntrepreneurApplication;
            _webHostEnvironment = webHostEnvironment;
        }


        public void OnGet(LegalEntrepreneurSearchModel searchModel)
        {

            LegalEntrepreneur = _legalEntrepreneurApplication.Search(searchModel);
        }


        public IActionResult OnGetEdit(long id)
        {
            var legalEntrepreneur = _legalEntrepreneurApplication.GetDetails(id);
            return Partial("Edit", legalEntrepreneur);
        }

        public JsonResult OnPostEdit(EditLegalEntrepreneur command)
        {
            var result = _legalEntrepreneurApplication.Edit(command);
            return new JsonResult(result);
        }

        public IActionResult OnGetGetInformation(long id)
        {
            var info = _legalEntrepreneurApplication.GetLegalEntrepreneurInformationBy(id);
            return Partial("Information", info);
        }
        public FileResult OnGetDownloadResume(long id)
        {
            var resume = _legalEntrepreneurApplication.GetResumeBy(id);
            string FilePath = Path.Combine(_webHostEnvironment.WebRootPath, "Pictures");
            string FileNameWithPath = Path.Combine(FilePath, resume);
            byte[] bytes = System.IO.File.ReadAllBytes(FileNameWithPath);
            return File(bytes, "application/octet-stream", resume);

        }
        
    }
}
