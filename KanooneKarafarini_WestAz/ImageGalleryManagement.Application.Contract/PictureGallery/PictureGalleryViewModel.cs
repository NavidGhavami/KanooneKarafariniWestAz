namespace ImageGalleryManagement.Application.Contract.PictureGallery
{
    public class PictureGalleryViewModel
    {
        public long Id { get; set; }
        public string Picture { get; set; }
        public bool IsRemoved { get; set; }
        public string CreationDate { get; set; }
    }
}
