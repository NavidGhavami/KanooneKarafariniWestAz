using System.Collections.Generic;
using System.IO;
using EntrepreneurManagement.Application.Contract.StudentEntrepreneur;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace ServiceHost.Areas.Administration.Pages.Entrepreneur.StudentEntrepreneur
{
    public class IndexModel : PageModel
    {
        [TempData]
        public string Message { get; set; }

        public List<StudentEntrepreneurViewModel> StudentEntrepreneur;
        public StudentEntrepreneurSearchModel SearchModel;

        private readonly IStudentEntrepreneurApplication _studentEntrepreneurApplication;
        private readonly IWebHostEnvironment _webHostEnvironment;


        public IndexModel(IStudentEntrepreneurApplication studentEntrepreneurApplication, IWebHostEnvironment webHostEnvironment)
        {
            _studentEntrepreneurApplication = studentEntrepreneurApplication;
            _webHostEnvironment = webHostEnvironment;
        }


        public void OnGet(StudentEntrepreneurSearchModel searchModel)
        {

            StudentEntrepreneur = _studentEntrepreneurApplication.Search(searchModel);
        }


        public IActionResult OnGetEdit(long id)
        {
            var studentEntrepreneur = _studentEntrepreneurApplication.GetDetails(id);
            return Partial("Edit", studentEntrepreneur);
        }

        public JsonResult OnPostEdit(EditStudentEntrepreneur command)
        {
            var result = _studentEntrepreneurApplication.Edit(command);
            return new JsonResult(result);
        }

        public IActionResult OnGetGetInformation(long id)
        {
            var info = _studentEntrepreneurApplication.GetStudentEntrepreneurInformationBy(id);
            return Partial("Information", info);
        }
        public FileResult OnGetDownloadResume(long id)
        {
            var resume = _studentEntrepreneurApplication.GetNationalCardPictureBy(id);
            string FilePath = Path.Combine(_webHostEnvironment.WebRootPath, "Pictures");
            string FileNameWithPath = Path.Combine(FilePath, resume);
            byte[] bytes = System.IO.File.ReadAllBytes(FileNameWithPath);
            return File(bytes, "application/octet-stream", resume);

        }
    }
}
