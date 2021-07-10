using System.ComponentModel.DataAnnotations;
using _0_Framework.Application;
using Microsoft.AspNetCore.Http;

namespace EntrepreneurManagement.Application.Contract.StudentEntrepreneur
{
    public class RegisterStudentEntrepreneur
    {
        [Required(ErrorMessage = ValidationMessages.IsRequired)]
        public string StudentName { get; set; }

        [Required(ErrorMessage = ValidationMessages.IsRequired)]
        public string StudentFamily { get; set; }

        [Required(ErrorMessage = ValidationMessages.IsRequired)]
        public string StudentNationalId { get; set; }

        [Required(ErrorMessage = ValidationMessages.IsRequired)]
        public string StudentBirthDate { get; set; }

        [Required(ErrorMessage = ValidationMessages.IsRequired)]
        public string Education { get; set; }

        [Required(ErrorMessage = ValidationMessages.IsRequired)]
        public string StudentCity { get; set; }

        [Required(ErrorMessage = ValidationMessages.IsRequired)]
        public string StudentSchool { get; set; }

        [Required(ErrorMessage = ValidationMessages.IsRequired)]
        public string ParentFullname { get; set; }

        [Required(ErrorMessage = ValidationMessages.IsRequired)]
        public string ParentNationalId { get; set; }

        [Required(ErrorMessage = ValidationMessages.IsRequired)]
        public string ParentJob { get; set; }

        [Required(ErrorMessage = ValidationMessages.IsRequired)]
        public string StudentPhone { get; set; }

        [Required(ErrorMessage = ValidationMessages.IsRequired)]
        public string StudentMobile { get; set; }

        [Required(ErrorMessage = ValidationMessages.IsRequired)]
        public string StudentAddress { get; set; }

        public IFormFile StudentNationalCardPicture { get; set; }
    }
}
