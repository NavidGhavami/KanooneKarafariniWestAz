using System.ComponentModel.DataAnnotations;
using _0_Framework.Application;

namespace CommonSectionManagement.Application.Contract.Footer
{
    public class CreateFooter
    {
        [Required(ErrorMessage = ValidationMessages.IsRequired)]
        public string Address { get; set; }

        [Required(ErrorMessage = ValidationMessages.IsRequired)]
        public string Phone { get; set; }

        [Required(ErrorMessage = ValidationMessages.IsRequired)]
        public string Mobile { get; set; }
        public string Fax { get; set; }
        public string Email { get; set; }
    }
}
