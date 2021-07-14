using System.Collections.Generic;
using EntrepreneurManagement.Application.Contract.EntrepreneurServices.CounselingCenter;
using EntrepreneurManagement.Application.Contract.EntrepreneurServices.EntrepreneurCafe;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace ServiceHost.Areas.Administration.Pages.EntrepreneurServices.EntrepreneurCafe
{
    public class IndexModel : PageModel
    {
        [TempData]
        public string Message { get; set; }

        public List<EntrepreneurCafeViewModel> EntrepreneurCafe;
        public EntrepreneurCafeSearchModel SearchModel;


        private readonly IEntrepreneurCafeApplication _entrepreneurCafeApplication;



        public IndexModel(IEntrepreneurCafeApplication entrepreneurCafeApplication)
        {
            _entrepreneurCafeApplication = entrepreneurCafeApplication;
        }


        public void OnGet(EntrepreneurCafeSearchModel searchModel)
        {

            EntrepreneurCafe = _entrepreneurCafeApplication.Search(searchModel);
        }

        public IActionResult OnGetCreate()
        {
            var entrepreneurCafe = new CreateEntrepreneurCafe();
            return Partial("Create", entrepreneurCafe);
        }

        public JsonResult OnPostCreate(CreateEntrepreneurCafe command)
        {
            var result = _entrepreneurCafeApplication.Create(command);
            return new JsonResult(result);
        }
        public IActionResult OnGetEdit(long id)
        {
            var entrepreneurCafe = _entrepreneurCafeApplication.GetDetails(id);
            return Partial("Edit", entrepreneurCafe);
        }

        public JsonResult OnPostEdit(EditEntrepreneurCafe command)
        {
            var result = _entrepreneurCafeApplication.Edit(command);
            return new JsonResult(result);
        }
    }
}
