using System;
using _0_Framework.Domain;

namespace CommonSectionManagement.Domain.AboutContactUs
{
    public class AboutContactUs : EntityBase
    {
        public string AboutUsText { get; private set; }
        public string ContactUsText { get; private set; }
        public string Address { get; private set; }
        public string Phone { get; private set; }
        public string Mobile { get; private set; }
        public string Fax { get; private set; }
        public string Email { get; private set; }
        public string GoogleMap { get; private set; }
        public bool IsRemoved { get; private set; }

        public AboutContactUs(string aboutUsText, string contactUsText, string address, string phone,
            string mobile, string fax, string email, string googleMap)
        {
            AboutUsText = aboutUsText;
            ContactUsText = contactUsText;
            Address = address;
            Phone = phone;
            Mobile = mobile;
            Fax = fax;
            Email = email;
            GoogleMap = googleMap;
            IsRemoved = false;
        }

        public void Edit(string aboutUsText, string contactUsText, string address, string phone,
            string mobile, string fax, string email, string googleMap)
        {
            AboutUsText = aboutUsText;
            ContactUsText = contactUsText;
            Address = address;
            Phone = phone;
            Mobile = mobile;
            Fax = fax;
            Email = email;
            GoogleMap = googleMap;
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
