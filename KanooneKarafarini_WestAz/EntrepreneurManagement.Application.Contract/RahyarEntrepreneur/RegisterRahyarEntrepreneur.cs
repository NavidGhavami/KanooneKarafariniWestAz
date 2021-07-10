using System.ComponentModel.DataAnnotations;
using _0_Framework.Application;
using Microsoft.AspNetCore.Http;

namespace EntrepreneurManagement.Application.Contract.RahyarEntrepreneur
{
    public class RegisterRahyarEntrepreneur
    {
        [Required(ErrorMessage = ValidationMessages.IsRequired)]
        public string RahyarName { get; set; }

        [Required(ErrorMessage = ValidationMessages.IsRequired)]
        public string RahyarFamily { get; set; }

        [Required(ErrorMessage = ValidationMessages.IsRequired)]
        public string RahyarNationalId { get; set; }

        [Required(ErrorMessage = ValidationMessages.IsRequired)]
        public string RahyarBirthDate { get; set; }

        [Required(ErrorMessage = ValidationMessages.IsRequired)]
        public string RahyarEducation { get; set; }
        [Required(ErrorMessage = ValidationMessages.IsRequired)]
        public string RahyarCourse { get; set; }

        [Required(ErrorMessage = ValidationMessages.IsRequired)]
        public string RahyarCity { get; set; }

        [Required(ErrorMessage = ValidationMessages.IsRequired)]
        public string RahyarPhone { get; set; }

        [Required(ErrorMessage = ValidationMessages.IsRequired)]
        public string RahyarMobile { get; set; }

        [Required(ErrorMessage = ValidationMessages.IsRequired)]
        public string RahyarAddress { get; set; }

        public IFormFile RahyarResume { get; set; }
    }
}
