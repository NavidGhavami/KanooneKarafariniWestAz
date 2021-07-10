using Microsoft.AspNetCore.Http;

namespace EntrepreneurManagement.Application.Contract.RahyarEntrepreneur
{
    public class RahyarEntrepreneurViewModel
    {
        public long Id { get; set; }
        public string RahyarName { get; set; }
        public string RahyarFamily { get; set; }
        public string RahyarNationalId { get; set; }
        public string RahyarBirthDate { get; set; }
        public string RahyarEducation { get; set; }
        public string RahyarCourse { get; set; }
        public string RahyarCity { get; set; }
        public string RahyarPhone { get; set; }
        public string RahyarMobile { get; set; }
        public string RahyarAddress { get; set; }
        public string CreationDate { get; set; }
    }
}
