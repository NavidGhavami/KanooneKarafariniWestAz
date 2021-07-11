using System.ComponentModel.DataAnnotations;
using _0_Framework.Application;

namespace EntrepreneurManagement.Application.Contract.BenefactorEntrepreneur
{
    public class RegisterBenefactorEntrepreneur
    {
        [Required(ErrorMessage = ValidationMessages.IsRequired)]
        public string BenefactorName { get; set; }

        [Required(ErrorMessage = ValidationMessages.IsRequired)]
        public string BenefactorFamily { get; set; }

        [Required(ErrorMessage = ValidationMessages.IsRequired)]
        public string BenefactorNationalId { get; set; }

        [Required(ErrorMessage = ValidationMessages.IsRequired)]
        public string BenefactorJob { get; set; }

        [Required(ErrorMessage = ValidationMessages.IsRequired)]
        public string BenefactorCooperation { get; set; }

        [Required(ErrorMessage = ValidationMessages.IsRequired)]
        public string BenefactorPhone { get; set; }

        [Required(ErrorMessage = ValidationMessages.IsRequired)]
        public string BenefactorMobile { get; set; }

        [Required(ErrorMessage = ValidationMessages.IsRequired)]
        public string BenefactorAddress { get; set; }

        public string CooperationDescription { get; set; }
    }
}
