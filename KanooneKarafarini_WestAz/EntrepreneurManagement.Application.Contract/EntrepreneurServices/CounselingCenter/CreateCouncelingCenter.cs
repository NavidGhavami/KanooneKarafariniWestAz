using System.ComponentModel.DataAnnotations;
using _0_Framework.Application;

namespace EntrepreneurManagement.Application.Contract.EntrepreneurServices.CounselingCenter
{
    public class CreateCouncelingCenter
    {
        [Required(ErrorMessage = ValidationMessages.IsRequired)]
        public string CouncelingCenterName { get; set; }

        [Required(ErrorMessage = ValidationMessages.IsRequired)]
        public string CouncelingCenterActivity { get; set; }

        [Required(ErrorMessage = ValidationMessages.IsRequired)]
        public string ManagerName { get; set; }

        [Required(ErrorMessage = ValidationMessages.IsRequired)]
        public string CouncelingCenterPhone { get; set; }

        [Required(ErrorMessage = ValidationMessages.IsRequired)]
        public string CouncelingCenterMobile { get; set; }

        [Required(ErrorMessage = ValidationMessages.IsRequired)]
        public string CouncelingCenterAddress { get; set; }
        public string Description { get; set; }
    }
}
