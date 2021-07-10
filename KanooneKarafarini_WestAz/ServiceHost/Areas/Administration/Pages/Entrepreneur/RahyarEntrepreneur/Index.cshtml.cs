using System.Collections.Generic;
using System.IO;
using EntrepreneurManagement.Application.Contract.RahyarEntrepreneur;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace ServiceHost.Areas.Administration.Pages.Entrepreneur.RahyarEntrepreneur
{
    public class IndexModel : PageModel
    {
        [TempData]
        public string Message { get; set; }

        public List<RahyarEntrepreneurViewModel> RahyarEntrepreneur;
        public RahyarEntrepreneurSearchModel SearchModel;

        private readonly IRahyarEntrepreneurApplication _rahyarEntrepreneurApplication;
        private readonly IWebHostEnvironment _webHostEnvironment;


        public IndexModel(IRahyarEntrepreneurApplication rahyarEntrepreneurApplication, IWebHostEnvironment webHostEnvironment)
        {
            _rahyarEntrepreneurApplication = rahyarEntrepreneurApplication;
            _webHostEnvironment = webHostEnvironment;
        }


        public void OnGet(RahyarEntrepreneurSearchModel searchModel)
        {

            RahyarEntrepreneur = _rahyarEntrepreneurApplication.Search(searchModel);
        }


        public IActionResult OnGetEdit(long id)
        {
            var rahyarEntrepreneur = _rahyarEntrepreneurApplication.GetDetails(id);
            return Partial("Edit", rahyarEntrepreneur);
        }

        public JsonResult OnPostEdit(EditRahyarEntrepreneur command)
        {
            var result = _rahyarEntrepreneurApplication.Edit(command);
            return new JsonResult(result);
        }

        public IActionResult OnGetGetInformation(long id)
        {
            var info = _rahyarEntrepreneurApplication.GetRahyarEntrepreneurInformationBy(id);
            return Partial("Information", info);
        }
        public FileResult OnGetDownloadResume(long id)
        {
            var resume = _rahyarEntrepreneurApplication.GetResumeBy(id);
            string FilePath = Path.Combine(_webHostEnvironment.WebRootPath, "Pictures");
            string FileNameWithPath = Path.Combine(FilePath, resume);
            byte[] bytes = System.IO.File.ReadAllBytes(FileNameWithPath);
            return File(bytes, "application/octet-stream", resume);

        }
    }
}
