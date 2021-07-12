using System.ComponentModel.DataAnnotations;
using _0_Framework.Application;
using Microsoft.AspNetCore.Http;

namespace EntrepreneurManagement.Application.Contract.EntrepreneurServices.SubmitIdea
{
    public class CreateSubmitIdea
    {
        [Required(ErrorMessage = ValidationMessages.IsRequired)]
        public string ApplicantName { get; set; }

        [Required(ErrorMessage = ValidationMessages.IsRequired)]
        public string ApplicantFamily { get; set; }

        [Required(ErrorMessage = ValidationMessages.IsRequired)]
        public string ApplicantNationalId { get; set; }

        [Required(ErrorMessage = ValidationMessages.IsRequired)]
        public string ProposalSubject { get; set; }

        [Required(ErrorMessage = ValidationMessages.IsRequired)]
        public string ApplicantPhone { get; set; }

        [Required(ErrorMessage = ValidationMessages.IsRequired)]
        public string ApplicantMobile { get; set; }

        [Required(ErrorMessage = ValidationMessages.IsRequired)]
        public string ApplicantAddress { get; set; }

        [Required(ErrorMessage = ValidationMessages.IsRequired)]
        public IFormFile SummaryProposal { get; set; }
    }
}
