using System.Collections.Generic;
using System.IO;
using System.Net.Mime;
using EntrepreneurManagement.Application.Contract.TrueEntrepreneur;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace ServiceHost.Areas.Administration.Pages.Entrepreneur.TrueEntrepreneur
{
    public class IndexModel : PageModel
    {
        [TempData]
        public string Message { get; set; }

        public List<TrueEntrepreneurViewModel> TrueEntrepreneur;
        public TrueEntrepreneurSearchModel SearchModel;

        private readonly ITrueEntrepreneurApplication _trueEntrepreneurApplication;
        private readonly IWebHostEnvironment _webHostEnvironment;


        public IndexModel(ITrueEntrepreneurApplication trueEntrepreneurApplication, IWebHostEnvironment webHostEnvironment)
        {
            _trueEntrepreneurApplication = trueEntrepreneurApplication;
            _webHostEnvironment = webHostEnvironment;
        }


        public void OnGet(TrueEntrepreneurSearchModel searchModel)
        {

            TrueEntrepreneur = _trueEntrepreneurApplication.Search(searchModel);
        }


        public IActionResult OnGetEdit(long id)
        {
            var trueEntrepreneur = _trueEntrepreneurApplication.GetDetails(id);
            return Partial("Edit", trueEntrepreneur);
        }

        public JsonResult OnPostEdit(EditTrueEntrepreneur command)
        {
            var result = _trueEntrepreneurApplication.Edit(command);
            return new JsonResult(result);
        }

        public IActionResult OnGetGetInformation(long id)
        {
            var info = _trueEntrepreneurApplication.GetTrueEntrepreneurInformationBy(id);
            return Partial("Information", info);
        }
        public FileResult OnGetDownloadResume(long id)
        {
            var resume = _trueEntrepreneurApplication.GetResumeBy(id);
            string FilePath = Path.Combine(_webHostEnvironment.WebRootPath, "Pictures");
            string FileNameWithPath = Path.Combine(FilePath, resume);
            byte[] bytes = System.IO.File.ReadAllBytes(FileNameWithPath);
            return File(bytes, "application/octet-stream", resume);

        }
        
    }
}
