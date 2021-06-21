using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using _01_Query.Contract.PictureGallery;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace ServiceHost.Pages
{
    public class PictureGalleryModel : PageModel
    {
        private readonly IPictureGalleryQuery _pictureGalleryQuery;

        public List<PictureGalleryQueryModel> PictureGallery;
        public PictureGalleryModel(IPictureGalleryQuery pictureGalleryQuery)
        {
            _pictureGalleryQuery = pictureGalleryQuery;
        }

        public void OnGet()
        {
            PictureGallery = _pictureGalleryQuery.GetPictureGallery();
        }
    }
}
