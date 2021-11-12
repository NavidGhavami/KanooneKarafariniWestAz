using System.Collections.Generic;
using System.IO;
using _01_Query.Contract.IntroduceEntrepreneur;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace ServiceHost.Pages
{
    public class IntroduceEntrepreneurModel : PageModel
    {
        private readonly IIntroduceEntrepreneurQuery _introduceEntrepreneurQuery;
        private readonly IWebHostEnvironment _webHostEnvironment;



        public List<IntroduceEntrepreneurQueryModel> IntroduceEntrepreneur;

        public IntroduceEntrepreneurModel(IIntroduceEntrepreneurQuery introduceEntrepreneurQuery, IWebHostEnvironment webHostEnvironment)
        {
            _introduceEntrepreneurQuery = introduceEntrepreneurQuery;
            _webHostEnvironment = webHostEnvironment;
        }

        public void OnGet()
        {
            IntroduceEntrepreneur = _introduceEntrepreneurQuery.GetIntroduceEntrepreneur();
        }

        public FileResult OnGetDownloadResume(long id)
        {
            var resume = _introduceEntrepreneurQuery.GetResumeBy(id);
            string FilePath = Path.Combine(_webHostEnvironment.WebRootPath, "Pictures");
            string FileNameWithPath = Path.Combine(FilePath, resume);
            byte[] bytes = System.IO.File.ReadAllBytes(FileNameWithPath);
            return File(bytes, "application/octet-stream", resume);

        }
    }
}
