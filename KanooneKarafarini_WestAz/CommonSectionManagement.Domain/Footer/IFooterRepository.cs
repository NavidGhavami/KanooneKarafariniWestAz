using System.Collections.Generic;
using _0_Framework.Domain;
using CommonSectionManagement.Application.Contract.Footer;

namespace CommonSectionManagement.Domain.Footer
{
    public interface IFooterRepository : IRepository<long, Footer>
    {
        EditFooter GetDetails(long id);
        List<FooterViewModel> GetList();
    }
}
