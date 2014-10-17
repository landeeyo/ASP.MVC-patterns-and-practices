using ComplexForms.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ComplexForms.Controllers
{
    public partial class HomeController : Controller
    {
        //
        // GET: /Home/
        [HttpGet]
        public virtual ActionResult Index()
        {
            ComplexVM model = new ComplexVM();

            SimpleFirstVM sub1 = new SimpleFirstVM();
            model.simpleFirstVM = sub1;

            SimpleSecondVM sub2 = new SimpleSecondVM();
            model.simpleSecondVM = sub2;

            return View(model);
        }

        [HttpPost]
        public virtual ActionResult Index(ComplexVM model)
        {
            return View(model);
        }

    }
}
