using System.Collections.Generic;
using _01_Query.Contract.Article;
using _01_Query.Contract.ArticleCategory;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace ServiceHost.Pages
{
    public class NewsCategoryModel : PageModel
    {
        private readonly IArticleQuery _articleQuery;
        private readonly IArticleCategoryQuery _articleCategoryQuery;

        public List<ArticleQueryModel> LatestArticle;
        public ArticleCategoryQueryModel ArticleCategory;
        public List<ArticleCategoryQueryModel> ArticleCategories;


        public NewsCategoryModel(IArticleQuery articleQuery, IArticleCategoryQuery articleCategoryQuery)
        {
            _articleQuery = articleQuery;
            _articleCategoryQuery = articleCategoryQuery;
        }

        public void OnGet(string id)
        {
            LatestArticle = _articleQuery.LatestArticles();
            ArticleCategory = _articleCategoryQuery.GetArticleCategoryBy(id);
            ArticleCategories = _articleCategoryQuery.GetArticleCategories();

        }
    }
}
