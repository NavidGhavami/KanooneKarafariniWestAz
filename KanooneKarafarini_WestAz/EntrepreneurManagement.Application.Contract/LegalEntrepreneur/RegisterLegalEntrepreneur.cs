using System.ComponentModel.DataAnnotations;
using _0_Framework.Application;
using Microsoft.AspNetCore.Http;

namespace EntrepreneurManagement.Application.Contract.LegalEntrepreneur
{
    public class RegisterLegalEntrepreneur
    {
       [Required(ErrorMessage = ValidationMessages.IsRequired)]
        public string Company { get; set; }

        [Required(ErrorMessage = ValidationMessages.IsRequired)]
        public string CompanyId { get; set; }

        [Required(ErrorMessage = ValidationMessages.IsRequired)]
        public string ManagerName { get; set; }

        [Required(ErrorMessage = ValidationMessages.IsRequired)]
        public string ManagerFamily { get; set; }

        [Required(ErrorMessage = ValidationMessages.IsRequired)]
        public string ManagerNationalId { get; set; }

        [Required(ErrorMessage = ValidationMessages.IsRequired)]
        public string CompanySubject { get; set; }

        [Required(ErrorMessage = ValidationMessages.IsRequired)]
        public string CompanyCity { get; set; }

        [Required(ErrorMessage = ValidationMessages.IsRequired)]
        public string CompanyAddress { get; set; }

        [Required(ErrorMessage = ValidationMessages.IsRequired)]
        public string CompanyPhone { get; set; }

        [Required(ErrorMessage = ValidationMessages.IsRequired)]
        public string CompanyMobile { get; set; }

        public IFormFile CompanyResume { get; set; }

        public string CreationDate { get; set; }
    }
}
