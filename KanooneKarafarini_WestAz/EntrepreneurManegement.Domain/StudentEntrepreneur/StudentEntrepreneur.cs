using _0_Framework.Domain;

namespace EntrepreneurManagement.Domain.StudentEntrepreneur
{
    public class StudentEntrepreneur : EntityBase
    {
        public string StudentName { get; private set; }
        public string StudentFamily { get; private set; }
        public string StudentNationalId { get; private set; }
        public string StudentBirthDate { get; private set; }
        public string Education { get; private set; }
        public string StudentCity { get; private set; }
        public string StudentSchool { get; private set; }
        public string ParentFullname { get; private set; }
        public string ParentNationalId { get; private set; }
        public string ParentJob { get; private set; }
        public string StudentPhone { get; private set; }
        public string StudentMobile { get; private set; }
        public string StudentAddress { get; private set; }
        public string StudentNationalCardPicture { get; private set; }

        public StudentEntrepreneur(string studentName, string studentFamily, string studentNationalId, string studentBirthDate,
            string education, string studentCity, string studentSchool, string parentFullname, string parentNationalId,
            string parentJob, string studentPhone, string studentMobile, string studentAddress, string studentNationalCardPicture)
        {
            StudentName = studentName;
            StudentFamily = studentFamily;
            StudentNationalId = studentNationalId;
            StudentBirthDate = studentBirthDate;
            Education = education;
            StudentCity = studentCity;
            StudentSchool = studentSchool;
            ParentFullname = parentFullname;
            ParentNationalId = parentNationalId;
            ParentJob = parentJob;
            StudentPhone = studentPhone;
            StudentMobile = studentMobile;
            StudentAddress = studentAddress;
            StudentNationalCardPicture = studentNationalCardPicture;

        }

        public void Edit(string studentName, string studentFamily, string studentNationalId, string studentBirthDate,
            string education, string studentCity, string studentSchool, string parentFullname, string parentNationalId,
            string parentJob, string studentPhone, string studentMobile, string studentAddress, string studentNationalCardPicture)
        {
            StudentName = studentName;
            StudentFamily = studentFamily;
            StudentNationalId = studentNationalId;
            StudentBirthDate = studentBirthDate;
            Education = education;
            StudentCity = studentCity;
            StudentSchool = studentSchool;
            ParentFullname = parentFullname;
            ParentNationalId = parentNationalId;
            ParentJob = parentJob;
            StudentPhone = studentPhone;
            StudentMobile = studentMobile;
            StudentAddress = studentAddress;

            if (!string.IsNullOrWhiteSpace(studentNationalCardPicture))
            {
                StudentNationalCardPicture = studentNationalCardPicture;
            }
        }
    }

}
