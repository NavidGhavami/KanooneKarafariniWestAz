using System.Collections.Generic;
using ImageGalleryManagement.Application.Contract.Managers;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace ServiceHost.Areas.Administration.Pages.ImageGallery.Managers
{
    public class IndexModel : PageModel
    {
        [TempData]
        public string Message { get; set; }

        public List<ManagersViewModel> Manegers;

        private readonly IManagersApplication _managersApplication;

        public IndexModel(IManagersApplication managersApplication)
        {
            _managersApplication = managersApplication;

        }


        public void OnGet()
        {

            Manegers = _managersApplication.GetList();
        }

        public IActionResult OnGetCreate()
        {
            var command = new CreateManagers();
            return Partial("./Create", command);

        }

        public JsonResult OnPostCreate(CreateManagers command)
        {
            var result = _managersApplication.Create(command);
            return new JsonResult(result);
        }

        public IActionResult OnGetEdit(long id)
        {
            var slide = _managersApplication.GetDetails(id);
            return Partial("Edit", slide);
        }

        public JsonResult OnPostEdit(EditManagers command)
        {
            var result = _managersApplication.Edit(command);
            return new JsonResult(result);
        }

        public IActionResult OnGetRemove(long id)
        {
            var result = _managersApplication.Remove(id);

            if (result.IsSuccedded)
            {
                return RedirectToPage("./Index");
            }

            Message = result.Message;
            return RedirectToPage("./Index");

        }
        public IActionResult OnGetRestore(long id)
        {
            var result = _managersApplication.Restore(id);
            if (result.IsSuccedded)
            {
                return RedirectToPage("./Index");
            }

            Message = result.Message;
            return RedirectToPage("./Index");
        }
    }
}
