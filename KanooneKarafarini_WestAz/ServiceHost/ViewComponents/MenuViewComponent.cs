using _01_Query;
using _01_Query.Contract.ArticleCategory;
using Microsoft.AspNetCore.Mvc;

namespace ServiceHost.ViewComponents
{
    public class MenuViewComponent : ViewComponent
    {
        private IArticleCategoryQuery _articleCategoryQuery;

        public MenuViewComponent(IArticleCategoryQuery articleCategoryQuery)
        {
            _articleCategoryQuery = articleCategoryQuery;
        }

        public IViewComponentResult Invoke()
        {
            var result = new MenuModel
            {
                ArticleCategories = _articleCategoryQuery.GetArticleCategories()
            };
            return View(result);
        }
    }
}
