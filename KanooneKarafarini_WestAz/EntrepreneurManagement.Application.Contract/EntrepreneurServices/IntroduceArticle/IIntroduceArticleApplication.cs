using System.Collections.Generic;
using _0_Framework.Application;

namespace EntrepreneurManagement.Application.Contract.EntrepreneurServices.IntroduceArticle
{
    public interface IIntroduceArticleApplication
    {
        OperationResult Create(CreateIntroduceArticle command);
        OperationResult Edit(EditIntroduceArticle command);
        EditIntroduceArticle GetDetails(long id);
        List<IntroduceArticleViewModel> Search(IntroduceArticleSearchModel searchModel);
        IntroduceArticleViewModel GetIntroduceArticleInformationBy(long id);
        string GetResumeBy(long id);
    }
}
