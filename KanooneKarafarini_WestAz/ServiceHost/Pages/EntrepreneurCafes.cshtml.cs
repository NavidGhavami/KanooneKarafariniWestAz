using System.Collections.Generic;
using _01_Query.Contract.EntrepreneurCafe;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace ServiceHost.Pages
{
    public class EntrepreneurCafesModel : PageModel
    {
        private readonly IEntrepreneurCafeQuery _entrepreneurCafeQuery;

        public List<EntrepreneurCafeQueryModel> EntrepreneurCafe;
        public EntrepreneurCafesModel(IEntrepreneurCafeQuery entrepreneurCafeQuery)
        {
            _entrepreneurCafeQuery = entrepreneurCafeQuery;
        }

        public void OnGet()
        {
            EntrepreneurCafe = _entrepreneurCafeQuery.GetEntrepreneurCafe();
        }
    }
}
