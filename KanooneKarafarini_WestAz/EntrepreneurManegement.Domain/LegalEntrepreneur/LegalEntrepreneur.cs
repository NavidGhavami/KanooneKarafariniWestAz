using _0_Framework.Domain;

namespace EntrepreneurManagement.Domain.LegalEntrepreneur
{
    public class LegalEntrepreneur : EntityBase
    {

        public string Company { get; private set; }
        public string CompanyId { get; private set; }
        public string ManagerName { get; private set; }
        public string ManagerFamily { get; private set; }
        public string ManagerNationalId { get; private set; }
        public string CompanySubject { get; private set; }
        public string CompanyCity { get; private set; }
        public string CompanyAddress { get; private set; }
        public string CompanyPhone { get; private set; }
        public string CompanyMobile { get; private set; }
        public string CompanyResume { get; private set; }

        public LegalEntrepreneur(string company, string companyId, string managerName, string managerFamily, string managerNationalId, 
            string companySubject, string companyCity, string companyAddress, string companyPhone, string companyMobile, string companyResume)
        {
            Company = company;
            CompanyId = companyId;
            ManagerName = managerName;
            ManagerFamily = managerFamily;
            ManagerNationalId = managerNationalId;
            CompanySubject = companySubject;
            CompanyCity = companyCity;
            CompanyAddress = companyAddress;
            CompanyPhone = companyPhone;
            CompanyMobile = companyMobile;
            CompanyResume = companyResume;
        }

        public void Edit(string company, string companyId, string managerName, string managerFamily, string managerNationalId,
            string companySubject, string companyCity, string companyAddress, string companyPhone, string companyMobile, string companyResume)
        {
            Company = company;
            CompanyId = companyId;
            ManagerName = managerName;
            ManagerFamily = managerFamily;
            ManagerNationalId = managerNationalId;
            CompanySubject = companySubject;
            CompanyCity = companyCity;
            CompanyAddress = companyAddress;
            CompanyPhone = companyPhone;
            CompanyMobile = companyMobile;

            if (!string.IsNullOrWhiteSpace(companyResume))
            {
                CompanyResume = companyResume;
            }
        }
    }
}
