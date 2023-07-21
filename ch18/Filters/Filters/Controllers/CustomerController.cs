using Filters.Infrastructure;
using System.Web.Mvc;

namespace Filters.Controllers
{
	public class CustomerController : Controller
    {
        [SimpleMessage(Message = "A")]
        [SimpleMessage(Message = "B")]
        public string Index()
        {
            return "This is the Customer controller";
        }
    }
}