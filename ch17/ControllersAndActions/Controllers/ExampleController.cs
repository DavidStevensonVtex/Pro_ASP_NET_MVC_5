using System;
using System.Web.Mvc;

namespace ControllersAndActions.Controllers
{
	public class ExampleController : Controller
    {
        public ViewResult Index()
        {
            TempData["Message"] = "Hello";
            TempData["Date"] = DateTime.Now;
            return View();
        }

        public RedirectToRouteResult Redirect2()
		{
            return RedirectToAction("Index");
		}

        public HttpStatusCodeResult StatusCode()
        {
            return new HttpUnauthorizedResult();
        }
    }
}