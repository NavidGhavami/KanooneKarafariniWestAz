using System.ComponentModel.DataAnnotations;
using _0_Framework.Application;
using Microsoft.AspNetCore.Http;

namespace EntrepreneurManagement.Application.Contract.TrueEntrepreneur
{
    public class RegisterTrueEntrepreneur
    {
        [Required(ErrorMessage = ValidationMessages.IsRequired)]
        public string Name { get; set; }

        [Required(ErrorMessage = ValidationMessages.IsRequired)]
        public string Family { get; set; }

        [Required(ErrorMessage = ValidationMessages.IsRequired)]
        public string NationalId { get; set; }

        [Required(ErrorMessage = ValidationMessages.IsRequired)]
        public string BirthDate { get; set; }

        [Required(ErrorMessage = ValidationMessages.IsRequired)]
        public string ActivitySubject { get; set; }

        [Required(ErrorMessage = ValidationMessages.IsRequired)]
        public string City { get; set; }

        [Required(ErrorMessage = ValidationMessages.IsRequired)]
        public string Address { get; set; }

        [Required(ErrorMessage = ValidationMessages.IsRequired)]
        public string Phone { get; set; }

        [Required(ErrorMessage = ValidationMessages.IsRequired)]
        public string Mobile { get; set; }

        public IFormFile Resume { get; set; }
    }
}
