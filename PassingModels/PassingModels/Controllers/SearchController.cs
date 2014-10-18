using PassingModels.Models.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PassingModels.Controllers
{
    public partial class SearchController : Controller
    {
        [HttpGet]
        public virtual ActionResult Search()
        {
            var model = new SearchVM();
            model.Setting = "test setting";
            //Setting2 will be lost during post because it isn't bound in the form on the view!
            model.Setting2 = "test setting2";
            return View(model);
        }

        [HttpPost]
        public virtual ActionResult Search(SearchVM model)
        {
            model.Results = new List<Models.DbModel>();
            model.Results.Add(new Models.DbModel()
            {
                Name = "test"
            });
            model.Results.Add(new Models.DbModel()
            {
                Name = "test2"
            });
            return View(model);
        }

    }
}
