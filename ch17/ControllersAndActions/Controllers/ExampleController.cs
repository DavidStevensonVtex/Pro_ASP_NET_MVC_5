using System;
using System.Web.Mvc;

namespace ControllersAndActions.Controllers
{
	public class ExampleController : Controller
    {
        public ViewResult Index()
        {
            DateTime date = DateTime.Now;
            return View(date);
        }
    }
}