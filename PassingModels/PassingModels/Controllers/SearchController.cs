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
            model.Setting2 = "test setting2";
            return View(model);
        }

        [HttpPost]
        public virtual ActionResult Search(SearchVM model)
        {
            var model2 = model.TrickyPersistence as SearchVM;
            return View(model);
        }

    }
}
