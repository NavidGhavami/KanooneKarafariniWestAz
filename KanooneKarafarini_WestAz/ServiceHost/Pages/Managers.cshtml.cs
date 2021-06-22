using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using _01_Query.Contract.Managers;
using _01_Query.Contract.PictureGallery;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace ServiceHost.Pages
{
    public class ManagersModel : PageModel
    {
        private readonly IManagerQuery _managerQuery;

        public List<ManagerQueryModel> Manager;

        public ManagersModel(IManagerQuery managerQuery)
        {
            _managerQuery = managerQuery;
        }


        public void OnGet()
        {
            Manager = _managerQuery.GetManager();
        }
    }
}
