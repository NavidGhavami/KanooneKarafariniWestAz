using System.Collections.Generic;
using _0_Framework.Application;

namespace CommonSectionManagement.Application.Contract.Footer
{
    public interface IFooterApplication
    {
        OperationResult Create(CreateFooter command);
        OperationResult Edit(EditFooter command);
        OperationResult Remove(long id);
        OperationResult Restore(long id);
        EditFooter GetDetails(long id);
        List<FooterViewModel> GetList();
    }
}
