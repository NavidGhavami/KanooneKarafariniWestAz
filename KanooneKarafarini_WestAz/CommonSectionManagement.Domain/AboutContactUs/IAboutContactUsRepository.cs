using System.Collections.Generic;
using _0_Framework.Domain;
using CommonSectionManagement.Application.Contract.AboutContactUs;

namespace CommonSectionManagement.Domain.AboutContactUs
{
    public interface IAboutContactUsRepository : IRepository<long, AboutContactUs>
    {
        EditAboutContactUs GetDetails(long id);
        List<AboutContactUsViewModel> GetList();
    }
}
