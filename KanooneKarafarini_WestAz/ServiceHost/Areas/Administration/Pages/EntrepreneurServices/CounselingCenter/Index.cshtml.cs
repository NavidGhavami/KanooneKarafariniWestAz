using System.Collections.Generic;
using EntrepreneurManagement.Application.Contract.EntrepreneurServices.CounselingCenter;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace ServiceHost.Areas.Administration.Pages.EntrepreneurServices.CounselingCenter
{
    public class IndexModel : PageModel
    {
        [TempData]
        public string Message { get; set; }

        public List<CouncelingCenterViewModel> CounselingCenter;
        public CounselingCenterSearchModel SearchModel;


        private readonly ICounselingCenterApplication _counselingCenterApplication;
        


        public IndexModel(ICounselingCenterApplication counselingCenterApplication)
        {
            _counselingCenterApplication = counselingCenterApplication;
        }


        public void OnGet(CounselingCenterSearchModel searchModel)
        {

            CounselingCenter = _counselingCenterApplication.Search(searchModel);
        }

        public IActionResult OnGetCreate()
        {
            var counselingCenter = new CreateCouncelingCenter();
            return Partial("Create", counselingCenter);
        }

        public JsonResult OnPostCreate(CreateCouncelingCenter command)
        {
            var result = _counselingCenterApplication.Create(command);
            return new JsonResult(result);
        }
        public IActionResult OnGetEdit(long id)
        {
            var counselingCenter = _counselingCenterApplication.GetDetails(id);
            return Partial("Edit", counselingCenter);
        }

        public JsonResult OnPostEdit(EditCouncelingCenter command)
        {
            var result = _counselingCenterApplication.Edit(command);
            return new JsonResult(result);
        }

        public IActionResult OnGetGetInformation(long id)
        {
            var info = _counselingCenterApplication.GetInformationBy(id);
            return Partial("Information", info);
        }
    }
}
