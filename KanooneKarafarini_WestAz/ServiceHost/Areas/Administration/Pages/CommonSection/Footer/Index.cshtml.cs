using System.Collections.Generic;
using CommonSectionManagement.Application.Contract.Footer;
using ImageGalleryManagement.Application.Contract.Slider;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace ServiceHost.Areas.Administration.Pages.CommonSection.Footer
{
    public class IndexModel : PageModel
    {
        [TempData]
        public string Message { get; set; }

        public List<FooterViewModel> Footer;

        private readonly IFooterApplication _footerApplication;

        public IndexModel(IFooterApplication footerApplication)
        {
            _footerApplication = footerApplication;

        }


        public void OnGet()
        {

            Footer = _footerApplication.GetList();
        }

        public IActionResult OnGetCreate()
        {
            var command = new CreateFooter();
            return Partial("./Create", command);

        }

        public JsonResult OnPostCreate(CreateFooter command)
        {
            var result = _footerApplication.Create(command);
            return new JsonResult(result);
        }

        public IActionResult OnGetEdit(long id)
        {
            var footer = _footerApplication.GetDetails(id);
            return Partial("Edit", footer);
        }

        public JsonResult OnPostEdit(EditFooter command)
        {
            var result = _footerApplication.Edit(command);
            return new JsonResult(result);
        }

        public IActionResult OnGetRemove(long id)
        {
            var result = _footerApplication.Remove(id);

            if (result.IsSuccedded)
            {
                return RedirectToPage("./Index");
            }

            Message = result.Message;
            return RedirectToPage("./Index");

        }
        public IActionResult OnGetRestore(long id)
        {
            var result = _footerApplication.Restore(id);
            if (result.IsSuccedded)
            {
                return RedirectToPage("./Index");
            }

            Message = result.Message;
            return RedirectToPage("./Index");
        }
    }
}
