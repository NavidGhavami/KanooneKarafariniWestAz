using _0_Framework.Domain;

namespace EntrepreneurManagement.Domain.EntrepreneurServices.CouncelingCenter
{
    public class CounselingCenter : EntityBase
    {
        public string CouncelingCenterName { get; private set; }
        public string CouncelingCenterActivity { get; private set; }
        public string ManagerName { get; private set; }
        public string CouncelingCenterPhone { get; private set; }
        public string CouncelingCenterMobile { get; private set; }
        public string CouncelingCenterAddress { get; private set; }
        public string Description { get; private set; }


        public CounselingCenter(string councelingCenterName, string councelingCenterActivity, string managerName, string councelingCenterPhone,
            string councelingCenterMobile, string councelingCenterAddress, string description)
        {
            CouncelingCenterName = councelingCenterName;
            CouncelingCenterActivity = councelingCenterActivity;
            ManagerName = managerName;
            CouncelingCenterPhone = councelingCenterPhone;
            CouncelingCenterMobile = councelingCenterMobile;
            CouncelingCenterAddress = councelingCenterAddress;
            Description = description;
        }


        public void Edit(string councelingCenterName, string councelingCenterActivity, string managerName, string councelingCenterPhone, string councelingCenterMobile, 
            string councelingCenterAddress, string description)
        {
            CouncelingCenterName = councelingCenterName;
            CouncelingCenterActivity = councelingCenterActivity;
            ManagerName = managerName;
            CouncelingCenterPhone = councelingCenterPhone;
            CouncelingCenterMobile = councelingCenterMobile;
            CouncelingCenterAddress = councelingCenterAddress;
            Description = description;
        }
    }
}
