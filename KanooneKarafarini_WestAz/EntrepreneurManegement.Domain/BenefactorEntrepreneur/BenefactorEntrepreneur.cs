using _0_Framework.Domain;

namespace EntrepreneurManagement.Domain.BenefactorEntrepreneur
{
    public class BenefactorEntrepreneur : EntityBase
    {
        public string BenefactorName { get; private set; }
        public string BenefactorFamily { get; private set; }
        public string BenefactorNationalId { get; private set; }
        public string BenefactorJob { get; private set; }
        public string BenefactorCooperation { get; private set; }
        public string BenefactorPhone { get; private set; }
        public string BenefactorMobile { get; private set; }
        public string BenefactorAddress { get; private set; }
        public string CooperationDescription { get; private set; }


        public BenefactorEntrepreneur(string benefactorName, string benefactorFamily, string benefactorNationalId, string benefactorJob, 
            string benefactorCooperation, string benefactorPhone, string benefactorMobile, string benefactorAddress, string cooperationDescription)
        {
            BenefactorName = benefactorName;
            BenefactorFamily = benefactorFamily;
            BenefactorNationalId = benefactorNationalId;
            BenefactorJob = benefactorJob;
            BenefactorCooperation = benefactorCooperation;
            BenefactorPhone = benefactorPhone;
            BenefactorMobile = benefactorMobile;
            BenefactorAddress = benefactorAddress;
            CooperationDescription = cooperationDescription;
        }

        public void Edit(string benefactorName, string benefactorFamily, string benefactorNationalId, string benefactorJob,
            string benefactorCooperation, string benefactorPhone, string benefactorMobile, string benefactorAddress, string cooperationDescription)
        {
            BenefactorName = benefactorName;
            BenefactorFamily = benefactorFamily;
            BenefactorNationalId = benefactorNationalId;
            BenefactorJob = benefactorJob;
            BenefactorCooperation = benefactorCooperation;
            BenefactorPhone = benefactorPhone;
            BenefactorMobile = benefactorMobile;
            BenefactorAddress = benefactorAddress;
            CooperationDescription = cooperationDescription;
        }
    }
}
