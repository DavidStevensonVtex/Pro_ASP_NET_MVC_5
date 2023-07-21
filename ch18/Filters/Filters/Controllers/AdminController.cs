using System.Web.Mvc;
using System.Web.Security;

namespace Filters.Controllers
{
	public class AdminController : Controller
    {
        public ActionResult Index()
        {
            if (!Request.IsAuthenticated)
			{
                FormsAuthentication.RedirectToLoginPage();
			}

            return null;
        }

        public ViewResult Create()
		{
            if (!Request.IsAuthenticated)
			{
                FormsAuthentication.RedirectToLoginPage();
            }

            return null;
        }
    }
}