using System.ComponentModel.DataAnnotations;
using _0_Framework.Application;
using Microsoft.AspNetCore.Http;

namespace EntrepreneurManagement.Application.Contract.EntrepreneurServices.IntroduceArticle
{
    public class CreateIntroduceArticle
    {
        [Required(ErrorMessage = ValidationMessages.IsRequired)]
        public string Title { get;  set; }

        [Required(ErrorMessage = ValidationMessages.IsRequired)]
        public string StateTitle { get;  set; }

        public IFormFile Photo { get;  set; }
        public IFormFile File { get;  set; }
    }
}
