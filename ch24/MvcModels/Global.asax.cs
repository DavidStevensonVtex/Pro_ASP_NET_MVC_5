using System.Web.Mvc;
using System.Web.Routing;
using MvcModels.Infrastructure;

namespace MvcModels
{
	public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            ValueProviderFactories.Factories.Insert(0, new CustomValueProviderFactory());
        }
    }
}
