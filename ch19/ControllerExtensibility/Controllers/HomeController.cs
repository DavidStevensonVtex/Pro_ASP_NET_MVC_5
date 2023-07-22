using ControllerExtensibility.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ControllerExtensibility.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View("Result", new Result
            {
                ControllerName = "Home",
                ActionName = "Index"
            });
        }

        [ActionName("Index")]
        public ActionResult LocalIndex()
        {
            return View("Result", new Result
            {
                ControllerName = "Home",
                ActionName = "LocalIndex"
            });
        }
        //The current request for action 'Index' on controller type 'HomeController' is ambiguous between the following action methods:
        //System.Web.Mvc.ActionResult LocalIndex() on type ControllerExtensibility.Controllers.HomeController
        //System.Web.Mvc.ActionResult Index() on type ControllerExtensibility.Controllers.HomeController
    }
}