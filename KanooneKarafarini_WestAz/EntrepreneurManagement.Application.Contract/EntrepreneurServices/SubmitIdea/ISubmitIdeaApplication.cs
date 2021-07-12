using System.Collections.Generic;
using _0_Framework.Application;

namespace EntrepreneurManagement.Application.Contract.EntrepreneurServices.SubmitIdea
{
    public interface ISubmitIdeaApplication
    {
        OperationResult Create(CreateSubmitIdea command);
        OperationResult Edit(EditSubmitIdea command);
        EditSubmitIdea GetDetails(long id);
        SubmitIdeaViewModel GetInformationBy(long id);
        List<SubmitIdeaViewModel> GetList();
        string GetSummaryProposalBy(long id);

    }
}
