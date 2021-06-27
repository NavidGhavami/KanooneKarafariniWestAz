using System.Collections.Generic;
using System.Linq;
using _01_Query.Contract.Footer;
using CommonSectionManagement.Infrastructure.EFCore;

namespace _01_Query.Query
{
    public class FooterQuery : IFooterQuery
    {
        private readonly CommonSectionContext _commonSection;

        public FooterQuery(CommonSectionContext commonSection)
        {
            _commonSection = commonSection;
        }

        public List<FooterQueryModel> GetFooter()
        {
            return _commonSection.Footers
                .Where(x=>x.IsRemoved == false)
                .Select(x => new FooterQueryModel
            {
                    Address = x.Address,
                    Phone = x.Phone,
                    Mobile = x.Mobile,
                    Fax = x.Fax,
                    Email = x.Email
            }).ToList();
        }
    }
}
