using System.Web.Mvc;
using System.Web.Security;

namespace Filters.Controllers
{
	public class AdminController : Controller
    {
        [Authorize]
        public ActionResult Index()
        {
            return null;
        }

        [Authorize]
        public ViewResult Create()
		{
            return null;
        }
    }
}