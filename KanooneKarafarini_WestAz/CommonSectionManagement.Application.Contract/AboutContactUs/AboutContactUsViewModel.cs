namespace CommonSectionManagement.Application.Contract.AboutContactUs
{
    public class AboutContactUsViewModel
    {
        public long Id { get; set; }
        public string AboutUsText { get; set; }
        public string ContactUsText { get; set; }
        public string Address { get; set; }
        public string Phone { get; set; }
        public string Mobile { get; set; }
        public string Fax { get; set; }
        public string Email { get; set; }
        public string CreationDate { get; set; }
        public bool IsRemoved { get; set; }
    }
}

