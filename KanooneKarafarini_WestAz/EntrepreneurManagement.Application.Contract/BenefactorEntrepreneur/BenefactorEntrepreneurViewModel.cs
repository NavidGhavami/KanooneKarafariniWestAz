using System.ComponentModel.DataAnnotations;
using _0_Framework.Application;

namespace EntrepreneurManagement.Application.Contract.BenefactorEntrepreneur
{
    public class BenefactorEntrepreneurViewModel
    {
        public long Id { get; set; }
        public string BenefactorName { get; set; }
        public string BenefactorFamily { get; set; }
        public string BenefactorNationalId { get; set; }
        public string BenefactorJob { get; set; }
        public string BenefactorCooperation { get; set; }
        public string BenefactorPhone { get; set; }
        public string BenefactorMobile { get; set; }
        public string BenefactorAddress { get; set; }
        public string CooperationDescription { get; set; }
        public string CreationDate { get; set; }
    }
}
