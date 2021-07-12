using _0_Framework.Domain;

namespace EntrepreneurManagement.Domain.EntrepreneurServices.SubmitIdea
{
    public class SubmitIdea : EntityBase
    {
        public string ApplicantName { get; private set; }
        public string ApplicantFamily { get; private set; }
        public string ApplicantNationalId { get; private set; }
        public string ProposalSubject { get; private set; }
        public string ApplicantPhone { get; private set; }
        public string ApplicantMobile { get; private set; }
        public string ApplicantAddress { get; private set; }
        public string SummaryProposal { get; private set; }


        public SubmitIdea(string applicantName, string applicantFamily, string applicantNationalId, string proposalSubject, string applicantPhone,
            string applicantMobile, string applicantAddress, string summaryProposal)
        {
            ApplicantName = applicantName;
            ApplicantFamily = applicantFamily;
            ApplicantNationalId = applicantNationalId;
            ProposalSubject = proposalSubject;
            ApplicantPhone = applicantPhone;
            ApplicantMobile = applicantMobile;
            ApplicantAddress = applicantAddress;
            SummaryProposal = summaryProposal;
        }

        public void Edit(string applicantName, string applicantFamily, string applicantNationalId, string proposalSubject, string applicantPhone,
            string applicantMobile, string applicantAddress, string summaryProposal)
        {
            ApplicantName = applicantName;
            ApplicantFamily = applicantFamily;
            ApplicantNationalId = applicantNationalId;
            ProposalSubject = proposalSubject;
            ApplicantPhone = applicantPhone;
            ApplicantMobile = applicantMobile;
            ApplicantAddress = applicantAddress;

            if (!string.IsNullOrWhiteSpace(summaryProposal))
            {
                SummaryProposal = summaryProposal;
            }
        }
    }
}
