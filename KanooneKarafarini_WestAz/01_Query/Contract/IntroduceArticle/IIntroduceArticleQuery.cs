using System.Collections.Generic;

namespace _01_Query.Contract.IntroduceArticle
{
   public interface IIntroduceArticleQuery
    {
        List<IntroduceArticleQueryModel> GetIntroduceArticle();
        string GetResumeBy(long id);
    }
}
