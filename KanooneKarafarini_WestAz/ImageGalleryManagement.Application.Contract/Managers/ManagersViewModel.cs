namespace ImageGalleryManagement.Application.Contract.Managers
{
    public class ManagersViewModel
    {
        public long Id { get; set; }
        public string Fullname { get; set; }
        public string Picture { get; set; }
        public string JobPosition { get; set; }
        public string OrganizationType { get; set; }
        public bool IsRemoved { get; set; }
        public string CreationDate { get; set; }
    }
}
