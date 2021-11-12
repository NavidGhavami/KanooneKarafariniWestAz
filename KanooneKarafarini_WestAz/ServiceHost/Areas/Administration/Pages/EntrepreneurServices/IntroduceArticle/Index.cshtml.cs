using System.Collections.Generic;
using System.IO;
using EntrepreneurManagement.Application.Contract.EntrepreneurServices.IntroduceArticle;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace ServiceHost.Areas.Administration.Pages.EntrepreneurServices.IntroduceArticle
{
    public class IndexModel : PageModel
    {
        [TempData]
        public string Message { get; set; }

        public List<IntroduceArticleViewModel> IntroduceArticle;
        public IntroduceArticleSearchModel SearchModel;

        private readonly IIntroduceArticleApplication _introduceArticleApplication;
        private readonly IWebHostEnvironment _webHostEnvironment;


        public IndexModel(IWebHostEnvironment webHostEnvironment, IIntroduceArticleApplication introduceArticleApplication)
        {
            _webHostEnvironment = webHostEnvironment;
            _introduceArticleApplication = introduceArticleApplication;
        }


        public void OnGet(IntroduceArticleSearchModel searchModel)
        {

            IntroduceArticle = _introduceArticleApplication.Search(searchModel);
        }

        public IActionResult OnGetCreate()
        {
            var command = new CreateIntroduceArticle();
            return Partial("./Create", command);
        }

        public JsonResult OnPostCreate(CreateIntroduceArticle command)
        {
            var result = _introduceArticleApplication.Create(command);
            return new JsonResult(result);
        }


        public IActionResult OnGetEdit(long id)
        {
            var introduceArticle = _introduceArticleApplication.GetDetails(id);
            return Partial("Edit", introduceArticle);
        }

        public JsonResult OnPostEdit(EditIntroduceArticle command)
        {
            var result = _introduceArticleApplication.Edit(command);
            return new JsonResult(result);
        }

        public IActionResult OnGetGetInformation(long id)
        {
            var info = _introduceArticleApplication.GetIntroduceArticleInformationBy(id);
            return Partial("Information", info);
        }
        public FileResult OnGetDownloadResume(long id)
        {
            var file = _introduceArticleApplication.GetResumeBy(id);
            string FilePath = Path.Combine(_webHostEnvironment.WebRootPath, "Pictures");
            string FileNameWithPath = Path.Combine(FilePath, file);
            byte[] bytes = System.IO.File.ReadAllBytes(FileNameWithPath);
            return File(bytes, "application/octet-stream", file);

        }
    }
}
