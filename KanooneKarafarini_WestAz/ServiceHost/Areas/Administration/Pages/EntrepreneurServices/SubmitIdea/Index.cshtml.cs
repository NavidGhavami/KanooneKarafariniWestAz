using System.Collections.Generic;
using System.IO;
using EntrepreneurManagement.Application.Contract.EntrepreneurServices.SubmitIdea;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace ServiceHost.Areas.Administration.Pages.EntrepreneurServices.SubmitIdea
{
    public class IndexModel : PageModel
    {
        [TempData]
        public string Message { get; set; }

        public List<SubmitIdeaViewModel> SubmitIdea;

        private readonly ISubmitIdeaApplication _submitIdeaApplication;
        private readonly IWebHostEnvironment _webHostEnvironment;


        public IndexModel(ISubmitIdeaApplication submitIdeaApplication, IWebHostEnvironment webHostEnvironment)
        {
            _submitIdeaApplication = submitIdeaApplication;
            _webHostEnvironment = webHostEnvironment;
        }


        public void OnGet()
        {

            SubmitIdea = _submitIdeaApplication.GetList();
        }


        public IActionResult OnGetEdit(long id)
        {
            var submitIdea = _submitIdeaApplication.GetDetails(id);
            return Partial("Edit", submitIdea);
        }

        public JsonResult OnPostEdit(EditSubmitIdea command)
        {
            var result = _submitIdeaApplication.Edit(command);
            return new JsonResult(result);
        }

        public IActionResult OnGetGetInformation(long id)
        {
            var info = _submitIdeaApplication.GetInformationBy(id);
            return Partial("Information", info);
        }
        public FileResult OnGetDownloadResume(long id)
        {
            var summaryProposal = _submitIdeaApplication.GetSummaryProposalBy(id);
            string FilePath = Path.Combine(_webHostEnvironment.WebRootPath, "Pictures");
            string FileNameWithPath = Path.Combine(FilePath, summaryProposal);
            byte[] bytes = System.IO.File.ReadAllBytes(FileNameWithPath);
            return File(bytes, "application/octet-stream", summaryProposal);

        }
    }
}
