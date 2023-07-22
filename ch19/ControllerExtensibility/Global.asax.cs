using System.Web.Mvc;
using System.Web.Routing;

namespace ControllerExtensibility
{
	public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            RouteConfig.RegisterRoutes(RouteTable.Routes);

            ControllerBuilder.Current.DefaultNamespaces.Add("MyControllerNamespace");
            ControllerBuilder.Current.DefaultNamespaces.Add("MyProject.*");

        }
    }
}
