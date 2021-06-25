using _0_Framework.Domain;

namespace ImageGalleryManagement.Domain.Partners
{
    public class Partners : EntityBase
    {
        public string Name { get; private set; }
        public string Picture { get; private set; }
        public string PictureAlt { get; private set; }
        public string PictureTitle { get; private set; }
        public string Link { get; private set; }
        public bool IsRemoved { get; private set; }

        public Partners(string name, string picture, string pictureAlt, string pictureTitle, string link)
        {
            Name = name;
            Picture = picture;
            PictureAlt = pictureAlt;
            PictureTitle = pictureTitle;
            Link = link;
            IsRemoved = false;
        }

        public void Edit(string name, string picture, string pictureAlt, string pictureTitle, string link)
        {
            Name = name;
            if (!string.IsNullOrWhiteSpace(picture))
            {
                Picture = picture;
            }
            PictureAlt = pictureAlt;
            PictureTitle = pictureTitle;
            Link = link;
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
