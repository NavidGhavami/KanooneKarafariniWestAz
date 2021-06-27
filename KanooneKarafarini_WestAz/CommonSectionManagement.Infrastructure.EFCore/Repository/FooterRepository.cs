using System.Collections.Generic;
using System.Linq;
using _0_Framework.Application;
using _0_Framework.Infrastructure;
using CommonSectionManagement.Application.Contract.Footer;
using CommonSectionManagement.Domain.Footer;

namespace CommonSectionManagement.Infrastructure.EFCore.Repository
{
    public class FooterRepository : RepositoryBase<long, Footer>, IFooterRepository
    {
        private readonly CommonSectionContext _context;
        public FooterRepository(CommonSectionContext context) : base(context)
        {
            _context = context;
        }

        public EditFooter GetDetails(long id)
        {
            return _context.Footers.Select(x => new EditFooter
            {
                Id = x.Id,
                Address = x.Address,
                Phone = x.Phone,
                Mobile = x.Mobile,
                Email = x.Email,
                Fax = x.Fax

            }).FirstOrDefault(x => x.Id == id);
        }

        public List<FooterViewModel> GetList()
        {
            return _context.Footers.Select(x => new FooterViewModel
            {
                Id = x.Id,
                Address = x.Address,
                Phone = x.Phone,
                Mobile = x.Mobile,
                Email = x.Email,
                Fax = x.Fax,
                CreationDate = x.CreationDate.ToFarsi(),
                IsRemoved = x.IsRemoved

            }).ToList();
        }
    }
}
