using _01_Query.Contract.Article;
using Microsoft.AspNetCore.Mvc;

namespace ServiceHost.ViewComponents
{
    public class ArticlesViewComponent : ViewComponent
    {
        private readonly IArticleQuery _articleQuery;

        public ArticlesViewComponent(IArticleQuery articleQuery)
        {
            _articleQuery = articleQuery;
        }

        public IViewComponentResult Invoke()
        {
            var article = _articleQuery.LatestArticles();
            return View(article);
        }
    }
}
