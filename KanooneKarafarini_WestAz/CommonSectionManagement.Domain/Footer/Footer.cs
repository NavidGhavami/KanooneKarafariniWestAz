using _0_Framework.Domain;

namespace CommonSectionManagement.Domain.Footer
{
    public class Footer : EntityBase
    {
        public string Address { get; private set; }
        public string Phone { get; private set; }
        public string Mobile { get; private set; }
        public string Fax { get; private set; }
        public string Email { get; private set; }
        public bool IsRemoved { get; private set; }

        public Footer(string address, string phone, string mobile, string fax, string email)
        {
            Address = address;
            Phone = phone;
            Mobile = mobile;
            Fax = fax;
            Email = email;
            IsRemoved = false;
        }

        public void Edit(string address, string phone, string mobile, string fax, string email)
        {
            Address = address;
            Phone = phone;
            Mobile = mobile;
            Fax = fax;
            Email = email;
        }

        public void Remove()
        {
            IsRemoved = true;
        }
        public void Restore()
        {
            IsRemoved = false;
        }
    }
}
