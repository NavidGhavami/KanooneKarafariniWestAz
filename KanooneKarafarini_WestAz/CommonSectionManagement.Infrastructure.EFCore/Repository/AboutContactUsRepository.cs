using System.Collections.Generic;
using System.Linq;
using _0_Framework.Application;
using _0_Framework.Infrastructure;
using CommonSectionManagement.Application.Contract.AboutContactUs;
using CommonSectionManagement.Domain.AboutContactUs;
using Microsoft.EntityFrameworkCore;

namespace CommonSectionManagement.Infrastructure.EFCore.Repository
{
    public class AboutContactUsRepository : RepositoryBase<long , AboutContactUs> , IAboutContactUsRepository
    {
        private readonly CommonSectionContext _context;
        public AboutContactUsRepository(CommonSectionContext context) : base(context)
        {
            _context = context;
        }

        public EditAboutContactUs GetDetails(long id)
        {
            return _context.AboutContactUs.Select(x => new EditAboutContactUs
            {
                Id = x.Id,
                AboutUsText = x.AboutUsText,
                ContactUsText = x.ContactUsText,
                Address = x.Address,
                Phone = x.Phone,
                Mobile = x.Mobile,
                Email = x.Email,
                Fax = x.Fax,
                GoogleMap = x.GoogleMap

            }).FirstOrDefault(x => x.Id == id);
        }

        public List<AboutContactUsViewModel> GetList()
        {
            return _context.AboutContactUs.Select(x => new AboutContactUsViewModel
            {
                Id = x.Id,
                AboutUsText = x.AboutUsText,
                ContactUsText = x.ContactUsText,
                Address = x.Address,
                Phone = x.Phone,
                Mobile = x.Mobile,
                Fax = x.Fax,
                Email = x.Email,
                CreationDate = x.CreationDate.ToFarsi(),
                IsRemoved = x.IsRemoved

            }).ToList();
        }
    }
}
