using System.Collections.Generic;
using ImageGalleryManagement.Application.Contract.Partners;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace ServiceHost.Areas.Administration.Pages.ImageGallery.Partners
{
    public class IndexModel : PageModel
    {
        [TempData]
        public string Message { get; set; }

        public List<PartnersViewModel> partner;

        private readonly IPartnersApplication _partnersApplication;

        public IndexModel(IPartnersApplication partnersApplication)
        {
            _partnersApplication = partnersApplication;

        }


        public void OnGet()
        {

            partner = _partnersApplication.GetList();
        }

        public IActionResult OnGetCreate()
        {
            var command = new CreatePartners();
            return Partial("./Create", command);

        }

        public JsonResult OnPostCreate(CreatePartners command)
        {
            var result = _partnersApplication.Create(command);
            return new JsonResult(result);
        }

        public IActionResult OnGetEdit(long id)
        {
            var slide = _partnersApplication.GetDetails(id);
            return Partial("Edit", slide);
        }

        public JsonResult OnPostEdit(EditPartners command)
        {
            var result = _partnersApplication.Edit(command);
            return new JsonResult(result);
        }

        public IActionResult OnGetRemove(long id)
        {
            var result = _partnersApplication.Remove(id);

            if (result.IsSuccedded)
            {
                return RedirectToPage("./Index");
            }

            Message = result.Message;
            return RedirectToPage("./Index");

        }
        public IActionResult OnGetRestore(long id)
        {
            var result = _partnersApplication.Restore(id);
            if (result.IsSuccedded)
            {
                return RedirectToPage("./Index");
            }

            Message = result.Message;
            return RedirectToPage("./Index");
        }
    }
}
