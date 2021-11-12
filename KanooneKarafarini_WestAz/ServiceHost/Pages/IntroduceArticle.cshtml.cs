using System.Collections.Generic;
using System.IO;
using _01_Query.Contract.IntroduceArticle;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace ServiceHost.Pages
{
    public class IntroduceArticleModel : PageModel
    {
        private readonly IIntroduceArticleQuery _introduceArticleQuery;
        private readonly IWebHostEnvironment _webHostEnvironment;



        public List<IntroduceArticleQueryModel> IntroduceArticle;

        public IntroduceArticleModel(IIntroduceArticleQuery introduceArticleQuery, IWebHostEnvironment webHostEnvironment)
        {
            _introduceArticleQuery = introduceArticleQuery;
            _webHostEnvironment = webHostEnvironment;
        }

        public void OnGet()
        {
            IntroduceArticle = _introduceArticleQuery.GetIntroduceArticle();
        }

        public FileResult OnGetDownloadResume(long id)
        {
            var file = _introduceArticleQuery.GetResumeBy(id);
            string FilePath = Path.Combine(_webHostEnvironment.WebRootPath, "Pictures");
            string FileNameWithPath = Path.Combine(FilePath, file);
            byte[] bytes = System.IO.File.ReadAllBytes(FileNameWithPath);
            return File(bytes, "application/octet-stream", file);

        }
    }
}
