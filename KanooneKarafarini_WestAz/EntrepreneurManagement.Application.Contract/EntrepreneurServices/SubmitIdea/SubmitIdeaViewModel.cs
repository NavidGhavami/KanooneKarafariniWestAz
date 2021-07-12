namespace EntrepreneurManagement.Application.Contract.EntrepreneurServices.SubmitIdea
{
    public class SubmitIdeaViewModel
    {
        public long Id { get; set; }
        public string ApplicantName { get; set; }
        public string ApplicantFamily { get; set; }
        public string ApplicantNationalId { get; set; }
        public string ProposalSubject { get; set; }
        public string ApplicantPhone { get; set; }
        public string ApplicantMobile { get; set; }
        public string ApplicantAddress { get; set; }
        public string CreationDate { get; set; }
    }
}
