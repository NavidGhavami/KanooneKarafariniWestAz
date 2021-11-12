namespace EntrepreneurManagement.Application.Contract.EntrepreneurServices.IntroduceEntrepreneur
{
    public class IntroduceEntrepreneurViewModel
    {
        public long Id { get; set; }
        public string Fullname { get; set; }
        public string Job { get; set; }
        public string StateTitle { get; set; }
        public string ResumeDescription { get; set; }
        public string Photo { get; set; }
        public string CreationDate { get; set; }
    }
}
