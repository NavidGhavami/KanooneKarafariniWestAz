using System.Collections.Generic;
using System.Linq;
using _01_Query.Contract.IntroduceArticle;
using EntrepreneurManagement.Infrastructure.EFCore;

namespace _01_Query.Query
{
    public class IntroduceArticleQuery : IIntroduceArticleQuery
    {
        private readonly EntrepreneurContext _entrepreneurContext;

        public IntroduceArticleQuery(EntrepreneurContext entrepreneurContext)
        {
            _entrepreneurContext = entrepreneurContext;
        }

        public List<IntroduceArticleQueryModel> GetIntroduceArticle()
        {
            return _entrepreneurContext.IntroduceArticles.Select(x => new IntroduceArticleQueryModel
            {
                Id = x.Id,
                Title = x.Title,
                Photo = x.Photo,
                StateTitle = x.StateTitle,
                File = x.File

            }).ToList();
        }

        public string GetResumeBy(long id)
        {
            var file = _entrepreneurContext.IntroduceArticles.FirstOrDefault(x => x.Id == id);

            if (file == null)
            {
                return new string("");
            }

            return file.File;
        }
    }
}
