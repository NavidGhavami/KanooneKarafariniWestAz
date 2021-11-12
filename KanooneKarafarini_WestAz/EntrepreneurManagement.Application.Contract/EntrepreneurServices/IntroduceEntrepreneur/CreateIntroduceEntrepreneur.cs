using System.ComponentModel.DataAnnotations;
using _0_Framework.Application;
using Microsoft.AspNetCore.Http;

namespace EntrepreneurManagement.Application.Contract.EntrepreneurServices.IntroduceEntrepreneur
{
    public class CreateIntroduceEntrepreneur
    {
        [Required(ErrorMessage = ValidationMessages.IsRequired)]
        public string Fullname { get; set; }

        [Required(ErrorMessage = ValidationMessages.IsRequired)]
        public string Job { get; set; }

        [Required(ErrorMessage = ValidationMessages.IsRequired)]
        public string StateTitle { get; set; }

        public string ResumeDescription { get; set; }
        public IFormFile ResumeFile { get; set; }
        public IFormFile Photo { get; set; }
    }
}
