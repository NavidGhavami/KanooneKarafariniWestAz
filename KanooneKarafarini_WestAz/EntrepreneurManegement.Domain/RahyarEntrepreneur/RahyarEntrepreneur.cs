using _0_Framework.Domain;

namespace EntrepreneurManagement.Domain.RahyarEntrepreneur
{
    public class RahyarEntrepreneur : EntityBase
    {
        public string RahyarName { get; private set; }
        public string RahyarFamily { get; private set; }
        public string RahyarNationalId { get; private set; }
        public string RahyarBirthDate { get; private set; }
        public string RahyarEducation { get; private set; }
        public string RahyarCourse { get; private set; }
        public string RahyarCity { get; private set; }
        public string RahyarPhone { get; private set; }
        public string RahyarMobile { get; private set; }
        public string RayharAddress { get; private set; }
        public string RahyarResume { get; private set; }

        public RahyarEntrepreneur(string rahyarName, string rahyarFamily, string rahyarNationalId, string rahyarBirthDate, string rahyarEducation, string rahyarCourse,
            string rahyarCity, string rahyarPhone, string rahyarMobile, string rayharAddress, string rahyarResume)
        {
            RahyarName = rahyarName;
            RahyarFamily = rahyarFamily;
            RahyarNationalId = rahyarNationalId;
            RahyarBirthDate = rahyarBirthDate;
            RahyarEducation = rahyarEducation;
            RahyarCourse = rahyarCourse;
            RahyarCity = rahyarCity;
            RahyarPhone = rahyarPhone;
            RahyarMobile = rahyarMobile;
            RayharAddress = rayharAddress;
            RahyarResume = rahyarResume;
        }

        public void Edit(string rahyarName, string rahyarFamily, string rahyarNationalId, string rahyarBirthDate, string rahyarEducation, string rahyarCourse,
            string rahyarCity, string rahyarPhone, string rahyarMobile, string rayharAddress, string rahyarResume)
        {
            RahyarName = rahyarName;
            RahyarFamily = rahyarFamily;
            RahyarNationalId = rahyarNationalId;
            RahyarBirthDate = rahyarBirthDate;
            RahyarEducation = rahyarEducation;
            RahyarCourse = rahyarCourse;
            RahyarCity = rahyarCity;
            RahyarPhone = rahyarPhone;
            RahyarMobile = rahyarMobile;
            RayharAddress = rayharAddress;

            if (!string.IsNullOrWhiteSpace(rahyarResume))
            {
                RahyarResume = rahyarResume;
            }
        }
    }
}
