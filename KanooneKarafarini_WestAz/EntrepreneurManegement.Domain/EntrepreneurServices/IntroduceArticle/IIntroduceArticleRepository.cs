using System.Collections.Generic;
using _0_Framework.Domain;
using EntrepreneurManagement.Application.Contract.EntrepreneurServices.IntroduceArticle;

namespace EntrepreneurManagement.Domain.EntrepreneurServices.IntroduceArticle
{
    public interface IIntroduceArticleRepository : IRepository<long ,IntroduceArticle>
    {
        EditIntroduceArticle GetDetails(long id);
        List<IntroduceArticleViewModel> Search(IntroduceArticleSearchModel searchModel);
        IntroduceArticleViewModel GetIntroduceArticleInformationBy(long id);
        string GetResumeBy(long id);
    }
}
