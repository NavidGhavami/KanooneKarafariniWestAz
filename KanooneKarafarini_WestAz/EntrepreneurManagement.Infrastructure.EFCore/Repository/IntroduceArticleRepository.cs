using System.Collections.Generic;
using System.Linq;
using _0_Framework.Application;
using _0_Framework.Infrastructure;
using EntrepreneurManagement.Application.Contract.EntrepreneurServices.IntroduceArticle;
using EntrepreneurManagement.Domain.EntrepreneurServices.IntroduceArticle;
using Microsoft.EntityFrameworkCore;

namespace EntrepreneurManagement.Infrastructure.EFCore.Repository
{
    public class IntroduceArticleRepository : RepositoryBase<long, IntroduceArticle>, IIntroduceArticleRepository
    {
        private readonly EntrepreneurContext _entrepreneurContext;
        public IntroduceArticleRepository(EntrepreneurContext entrepreneurContext) : base(entrepreneurContext)
        {
            _entrepreneurContext = entrepreneurContext;
        }

        public EditIntroduceArticle GetDetails(long id)
        {
            return _entrepreneurContext.IntroduceArticles.Select(x => new EditIntroduceArticle
            {
                Id = x.Id,
                Title = x.Title,
                StateTitle = x.StateTitle

            }).FirstOrDefault(x => x.Id == id);
        }

        public List<IntroduceArticleViewModel> Search(IntroduceArticleSearchModel searchModel)
        {
            var query = _entrepreneurContext.IntroduceArticles.Select(x => new IntroduceArticleViewModel
            {
                Id = x.Id,
                Title = x.Title,
                Photo = x.Photo,
                StateTitle = x.StateTitle,
                CreationDate = x.CreationDate.ToFarsi()
            });

            if (!string.IsNullOrWhiteSpace(searchModel.Title))
            {
                query = query.Where(x => x.Title.Contains(searchModel.Title));
            }
            if (!string.IsNullOrWhiteSpace(searchModel.StateTitle))
            {
                query = query.Where(x => x.StateTitle.Contains(searchModel.StateTitle));
            }

            return query.OrderByDescending(x=>x.Id).ToList();
        }

        public IntroduceArticleViewModel GetIntroduceArticleInformationBy(long id)
        {
            var info = _entrepreneurContext.IntroduceArticles.FirstOrDefault(x => x.Id == id);

            if (info == null)
            {
                return new IntroduceArticleViewModel();
            }

            var information = new IntroduceArticleViewModel
            {
                Id = info.Id,
                Title = info.Title,
                Photo = info.Photo,
                StateTitle = info.StateTitle,
                CreationDate = info.CreationDate.ToFarsi()
            };

            return information;
        }

        public string GetResumeBy(long id)
        {
            var resume = _entrepreneurContext.IntroduceArticles.FirstOrDefault(x => x.Id == id);

            if (resume == null)
            {
                return new string("");
            }

            return resume.File;
        }
    }
}
