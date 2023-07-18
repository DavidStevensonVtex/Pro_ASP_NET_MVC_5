using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Mvc.Routing.Constraints;
using System.Web.Routing;

namespace UrlsAndRoutes
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            Route myRoute = routes.MapRoute("MyRoute", "{controller}/{action}/{id}/{*catchall}",
                new { controller = "Home", action = "Index", id = UrlParameter.Optional },
                new { 
                    controller = "^H.*", 
                    action = "^Index$|^About$", 
                    httpMethod = new HttpMethodConstraint("GET"), 
                    id = new CompoundRouteConstraint( new IRouteConstraint[]
					{
                        new AlphaRouteConstraint(),
                        new MinLengthRouteConstraint(6)
					})
                },
                new[] { "UrlsAndRoutes.Controllers" });
        }
    }
}
