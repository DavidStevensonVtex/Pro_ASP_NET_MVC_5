using System.Web.Mvc;
using LanguageFeatures.Models;

namespace LanguageFeatures.Controllers
{
	public class HomeController : Controller
    {
        public string Index()
        {
            return "Navigate to a URL to show an example";
        }

        public ViewResult CreateProduct()
		{
            // createa new Product object
            Product myProduct = new Product()
            {
                ProductID = 100,
                Name = "Kayak",
                Description = "A boat for one person",
                Price = 275M,
                Category = "Watersports"
            };

            // generate the view
            return View("Result", (object) $"Category: {myProduct.Category}");
		}
    }
}