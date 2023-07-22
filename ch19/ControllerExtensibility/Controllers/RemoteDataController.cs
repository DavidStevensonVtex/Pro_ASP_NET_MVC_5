using System.Threading.Tasks;
using System.Web.Mvc;
using ControllerExtensibility.Models;

namespace ControllerExtensibility.Controllers
{
	public class RemoteDataController : Controller
    {
        public async Task<ActionResult> Data()
		{
            RemoteService service = new RemoteService();
            string data = await Task<string>.Factory.StartNew(() => new RemoteService().GetRemoteData());
            return View((object)data);
		}
    }
}