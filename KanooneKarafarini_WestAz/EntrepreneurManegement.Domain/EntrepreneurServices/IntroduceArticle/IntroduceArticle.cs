using _0_Framework.Domain;

namespace EntrepreneurManagement.Domain.EntrepreneurServices.IntroduceArticle
{
    public class IntroduceArticle : EntityBase
    {
        public string Title { get; private set; }
        public string StateTitle { get; private set; }
        public string Photo { get; private set; }
        public string File { get; private set; }

        public IntroduceArticle(string title, string stateTitle, string photo, string file)
        {
            Title = title;
            StateTitle = stateTitle;
            Photo = photo;
            File = file;
        }

        public void Edit(string title, string stateTitle, string photo, string file)
        {
            Title = title;
            StateTitle = stateTitle;

            if (!string.IsNullOrWhiteSpace(photo))
            {
                Photo = photo;
            }
            if (!string.IsNullOrWhiteSpace(file))
            {
                File = file;
            }
        }
    }
}
