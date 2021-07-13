using System.Collections.Generic;
using _01_Query.Contract.CounselingCenter;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace ServiceHost.Pages
{
    public class CounselingCentersModel : PageModel
    {
        private readonly ICounselingCenterQuery _counselingCenterQuery;

        public List<CounselingCenterQueryModel> CounselingCenter;
        public CounselingCentersModel(ICounselingCenterQuery counselingCenterQuery)
        {
            _counselingCenterQuery = counselingCenterQuery;
        }

        public void OnGet()
        {
            CounselingCenter = _counselingCenterQuery.GetCounselingCenter();
        }
    }
}
