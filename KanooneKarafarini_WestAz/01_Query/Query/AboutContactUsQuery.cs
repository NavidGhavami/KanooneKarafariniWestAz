using System.Collections.Generic;
using System.Linq;
using _01_Query.Contract.AboutContactUs;
using CommonSectionManagement.Infrastructure.EFCore;

namespace _01_Query.Query
{
    public class AboutContactUsQuery : IAboutContactUsQuery
    {
        private readonly CommonSectionContext _commonSectionContext;

        public AboutContactUsQuery(CommonSectionContext commonSectionContext)
        {
            _commonSectionContext = commonSectionContext;
        }

        public List<AboutContactUsQueryModel> GetAboutContactUs()
        {
            return _commonSectionContext.AboutContactUs
                .Where(x => x.IsRemoved == false)
                .Select(x => new AboutContactUsQueryModel
                {
                    AboutUsText = x.AboutUsText,
                    ContactUsText = x.ContactUsText,
                    Address = x.Address,
                    Phone = x.Phone,
                    Mobile = x.Mobile,
                    Fax = x.Fax,
                    Email = x.Email,
                    GoogleMap = x.GoogleMap

                }).ToList();
        }
    }
}
