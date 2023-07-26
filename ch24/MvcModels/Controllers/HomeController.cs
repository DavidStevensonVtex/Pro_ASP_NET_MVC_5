using System.Linq;
using System.Web.Mvc;
using MvcModels.Models;

namespace MvcModels.Controllers
{
	public class HomeController : Controller
    {
        private Person[] personData =
        {
            new Person { FirstName = "Adam", LastName = "Freeman", Role = Role.Admin },
            new Person { FirstName = "Jacqui", LastName = "Griffyth", Role = Role.User },
            new Person { FirstName = "John", LastName = "Smith", Role = Role.User },
            new Person { FirstName = "Anne", LastName = "Jones", Role = Role.Guest }
        };

        public ActionResult Index( int id )
        {
            Person dataItem = personData.Where(p => p.PersonId == id).First();
            return View(dataItem);
        }
    }
}