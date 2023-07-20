using System;
using System.Web.Mvc;

namespace ControllersAndActions.Controllers
{
	public class ExampleController : Controller
    {
        public ViewResult Index()
        {
            ViewBag.Message = TempData["Message"];
            ViewBag.Date = TempData["Date"];
            return View();
        }

        public RedirectToRouteResult Redirect2()
		{
            // Preserving Data Across a Redirection
            TempData["Message"] = "Hello";
            TempData["Date"] = DateTime.Now;
            return RedirectToAction("Index");
		}
    }
}