using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Filters.Controllers
{
    [Authorize(Roles = "trader")]
    public class ExampleController : Controller
    {
        [OutputCache(Duration =60)]
        public ActionResult Index()
        {
            return View();
        }
    }
}