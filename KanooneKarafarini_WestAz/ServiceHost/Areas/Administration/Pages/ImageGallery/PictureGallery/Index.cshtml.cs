using ImageGalleryManagement.Application.Contract.PictureGallery;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Collections.Generic;

namespace ServiceHost.Areas.Administration.Pages.ImageGallery.PictureGallery
{
    public class IndexModel : PageModel
    {
        [TempData]
        public string Message { get; set; }

        public List<PictureGalleryViewModel> pictureGallery;

        private readonly IPictureGalleryApplication _pictureGalleryApplication;

        public IndexModel(IPictureGalleryApplication pictureGalleryApplication)
        {
            _pictureGalleryApplication = pictureGalleryApplication;
        }


        public void OnGet()
        {

            pictureGallery = _pictureGalleryApplication.GetList();
        }

        public IActionResult OnGetCreate()
        {
            var command = new CreatePictureGallery();
            return Partial("./Create", command);

        }

        public JsonResult OnPostCreate(CreatePictureGallery command)
        {
            var result = _pictureGalleryApplication.Create(command);
            return new JsonResult(result);
        }

        public IActionResult OnGetEdit(long id)
        {
            var picture = _pictureGalleryApplication.GetDetails(id);
            return Partial("Edit", picture);
        }

        public JsonResult OnPostEdit(EditPictureGallery command)
        {
            var result = _pictureGalleryApplication.Edit(command);
            return new JsonResult(result);
        }

        public IActionResult OnGetRemove(long id)
        {
            var result = _pictureGalleryApplication.Remove(id);

            if (result.IsSuccedded)
            {
                return RedirectToPage("./Index");
            }

            Message = result.Message;
            return RedirectToPage("./Index");

        }
        public IActionResult OnGetRestore(long id)
        {
            var result = _pictureGalleryApplication.Restore(id);
            if (result.IsSuccedded)
            {
                return RedirectToPage("./Index");
            }

            Message = result.Message;
            return RedirectToPage("./Index");
        }
    }
}
