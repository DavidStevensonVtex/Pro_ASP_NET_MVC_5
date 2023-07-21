using Filters.Infrastructure;
using System.Web.Mvc;

namespace Filters.Controllers
{
	public class CustomerController : Controller
    {
        [SimpleMessage(Message = "A", Order = 1)]
        [SimpleMessage(Message = "B", Order = 2)]
        public string Index()
        {
            return "This is the Customer controller";
        }
    }
}