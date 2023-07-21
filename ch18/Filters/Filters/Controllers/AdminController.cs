using System.Web.Mvc;
using System.Web.Security;

namespace Filters.Controllers
{
    [Authorize]
	public class AdminController : Controller
    {
        public ActionResult Index()
        {
            return null;
        }

        public ViewResult Create()
		{
            return null;
        }
    }
}