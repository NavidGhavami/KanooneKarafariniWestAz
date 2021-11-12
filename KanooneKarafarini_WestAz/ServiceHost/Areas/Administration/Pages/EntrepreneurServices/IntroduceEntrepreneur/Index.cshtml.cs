using System.Collections.Generic;
using System.IO;
using EntrepreneurManagement.Application.Contract.EntrepreneurServices.IntroduceEntrepreneur;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace ServiceHost.Areas.Administration.Pages.EntrepreneurServices.IntroduceEntrepreneur
{
    public class IndexModel : PageModel
    {
        [TempData]
        public string Message { get; set; }

        public List<IntroduceEntrepreneurViewModel> IntroduceEntrepreneur;
        public IntroduceEntrepreneurSearchModel SearchModel;

        private readonly IIntroduceEntrepreneurApplication _introduceEntrepreneurApplication;
        private readonly IWebHostEnvironment _webHostEnvironment;


        public IndexModel( IWebHostEnvironment webHostEnvironment, IIntroduceEntrepreneurApplication introduceEntrepreneurApplication)
        {
            _webHostEnvironment = webHostEnvironment;
            _introduceEntrepreneurApplication = introduceEntrepreneurApplication;
        }


        public void OnGet(IntroduceEntrepreneurSearchModel searchModel)
        {

            IntroduceEntrepreneur = _introduceEntrepreneurApplication.Search(searchModel);
        }

        public IActionResult OnGetCreate()
        {
            var command = new CreateIntroduceEntrepreneur();
            return Partial("./Create", command);
        }

        public JsonResult OnPostCreate(CreateIntroduceEntrepreneur command)
        {
            var result = _introduceEntrepreneurApplication.Create(command);
            return new JsonResult(result);
        }


        public IActionResult OnGetEdit(long id)
        {
            var introduceEntrepreneur = _introduceEntrepreneurApplication.GetDetails(id);
            return Partial("Edit", introduceEntrepreneur);
        }

        public JsonResult OnPostEdit(EditIntroduceEntrepreneur command)
        {
            var result = _introduceEntrepreneurApplication.Edit(command);
            return new JsonResult(result);
        }

        public IActionResult OnGetGetInformation(long id)
        {
            var info = _introduceEntrepreneurApplication.GetIntroduceEntrepreneurInformationBy(id);
            return Partial("Information", info);
        }
        public FileResult OnGetDownloadResume(long id)
        {
            var resume = _introduceEntrepreneurApplication.GetResumeBy(id);
            string FilePath = Path.Combine(_webHostEnvironment.WebRootPath, "Pictures");
            string FileNameWithPath = Path.Combine(FilePath, resume);
            byte[] bytes = System.IO.File.ReadAllBytes(FileNameWithPath);
            return File(bytes, "application/octet-stream", resume);

        }
    }
}
