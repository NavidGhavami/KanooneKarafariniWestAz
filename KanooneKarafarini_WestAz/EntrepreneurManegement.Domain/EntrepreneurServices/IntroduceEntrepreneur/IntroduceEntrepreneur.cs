using _0_Framework.Domain;

namespace EntrepreneurManagement.Domain.EntrepreneurServices.IntroduceEntrepreneur
{
    public class IntroduceEntrepreneur : EntityBase
    {
        public string Fullname { get; private set; }
        public string Job { get; private set; }
        public string StateTitle { get; private set; }
        public string ResumeFile { get; private set; }
        public string ResumeDescription { get; private set; }
        public string Photo { get; private set; }

        public IntroduceEntrepreneur(string fullname, string job, string stateTitle, string resumeFile, string resumeDescription, string photo)
        {
            Fullname = fullname;
            Job = job;
            StateTitle = stateTitle;
            ResumeFile = resumeFile;
            ResumeDescription = resumeDescription;
            Photo = photo;
        }

        public void Edit(string fullname, string job, string stateTitle, string resumeFile, string resumeDescription, string photo)
        {
            Fullname = fullname;
            Job = job;
            StateTitle = stateTitle;
            ResumeDescription = resumeDescription;

            if (!string.IsNullOrWhiteSpace(resumeFile))
            {
                ResumeFile = resumeFile;
            }

            if (!string.IsNullOrWhiteSpace(photo))
            {
                Photo = photo;
            }
        }
    }
}
