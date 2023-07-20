using ControllersAndActions.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ControllersAndActions.Controllers
{
    public class DerivedController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Message = "Hello from the DerivedController Index Method";
            return View("MyView");
        }

        public ActionResult ProduceOutput()
		{
            return Redirect("/Basic/Index");
		}
    }
}