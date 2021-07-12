using System.Collections.Generic;
using _0_Framework.Domain;
using EntrepreneurManagement.Application.Contract.EntrepreneurServices.SubmitIdea;

namespace EntrepreneurManagement.Domain.EntrepreneurServices.SubmitIdea
{
    public interface ISubmitIdeaRepository : IRepository<long, SubmitIdea>
    {
        EditSubmitIdea GetDetails(long id);
        List<SubmitIdeaViewModel> GetList();
        SubmitIdeaViewModel GetInformationBy(long id);
        string GetSummaryProposalBy(long id);
    }
}
