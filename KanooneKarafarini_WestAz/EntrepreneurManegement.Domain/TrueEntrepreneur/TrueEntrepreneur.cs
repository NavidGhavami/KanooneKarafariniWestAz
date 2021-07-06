using _0_Framework.Domain;

namespace EntrepreneurManagement.Domain.TrueEntrepreneur
{
    public class TrueEntrepreneur : EntityBase
    {
        public string Name { get; private set; }
        public string Family { get; private set; }
        public string NationalId { get; private set; }
        public string BirthDate { get; private set; }
        public string ActivitySubject { get; private set; }
        public string City { get; private set; }
        public string Address { get; private set; }
        public string Phone { get; private set; }
        public string Mobile { get; private set; }
        public string Resume { get; private set; }

        public TrueEntrepreneur(string name, string family, string nationalId, string birthDate, string activitySubject, 
            string city, string address, string phone, string mobile, string resume)
        {
            Name = name;
            Family = family;
            NationalId = nationalId;
            BirthDate = birthDate;
            ActivitySubject = activitySubject;
            City = city;
            Address = address;
            Phone = phone;
            Mobile = mobile;
            Resume = resume;
        }


        public void Edit(string name, string family, string nationalId, string birthDate, string activitySubject,
            string city, string address, string phone, string mobile, string resume)
        {
            Name = name;
            Family = family;
            NationalId = nationalId;
            BirthDate = birthDate;
            ActivitySubject = activitySubject;
            City = city;
            Address = address;
            Phone = phone;
            Mobile = mobile;

            if (!string.IsNullOrWhiteSpace(resume))
            {
                Resume = resume;
            }
        }
    }
}
