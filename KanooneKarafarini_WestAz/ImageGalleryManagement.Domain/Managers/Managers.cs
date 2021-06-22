using _0_Framework.Domain;

namespace ImageGalleryManagement.Domain.Managers
{
    public class Managers : EntityBase
    {
        public string Fullname { get; private set; }
        public string JobPosition { get; private set; }
        public string OrganizationType { get; private set; }
        public string Email { get; private set; }
        public string Phone { get; private set; }
        public string Mobile { get; set; }
        public string Picture { get; private set; }
        public string PictureAlt { get; private set; }
        public string PictureTitle { get; private set; }
        public bool IsRemoved { get; private set; }

        public Managers(string fullname, string jobPosition, string organizationType, string email, string phone,
            string mobile, string picture, string pictureAlt, string pictureTitle)
        {
            Fullname = fullname;
            JobPosition = jobPosition;
            OrganizationType = organizationType;
            Email = email;
            Phone = phone;
            Mobile = mobile;
            Picture = picture;
            PictureAlt = pictureAlt;
            PictureTitle = pictureTitle;
            IsRemoved = false;
        }

        public void Edit(string fullname, string jobPosition, string organizationType, string email, string phone,
            string mobile, string picture, string pictureAlt, string pictureTitle)
        {
            if (!string.IsNullOrWhiteSpace(picture))
            {
                Picture = picture;
            }

            Fullname = fullname;
            JobPosition = jobPosition;
            OrganizationType = organizationType;
            Email = email;
            Phone = phone;
            Mobile = mobile;
            PictureAlt = pictureAlt;
            PictureTitle = pictureTitle;
        }
        public void Remove()
        {
            IsRemoved = true;
        }
        public void Restore()
        {
            IsRemoved = false;
        }
    }
}
