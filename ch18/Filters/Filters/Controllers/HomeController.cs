using System.Web.Mvc;
using Filters.Infrastructure;

namespace Filters.Controllers
{
    [CustomAuth(false)]
	public class HomeController : Controller
    {
        public string Index()
        {
            return "This is the Index action on the Home controller";
        }
    }
}