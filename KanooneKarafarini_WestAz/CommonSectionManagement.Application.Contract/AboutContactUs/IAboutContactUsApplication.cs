using System.Collections.Generic;
using _0_Framework.Application;

namespace CommonSectionManagement.Application.Contract.AboutContactUs
{
    public interface IAboutContactUsApplication
    {
        OperationResult Create(CreateAboutContactUs command);
        OperationResult Edit(EditAboutContactUs command);
        OperationResult Remove(long id);
        OperationResult Restore(long id);
        EditAboutContactUs GetDetails(long id);
        List<AboutContactUsViewModel> GetList();
    }
}
