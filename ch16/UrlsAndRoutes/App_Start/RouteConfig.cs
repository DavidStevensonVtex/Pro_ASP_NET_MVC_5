using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Mvc.Routing.Constraints;
using System.Web.Routing;
using UrlsAndRoutes.Infrastructure;

namespace UrlsAndRoutes
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.MapMvcAttributeRoutes();

            routes.MapRoute("Default", "{controller}/{action}/{id}",
                new { controller = "Home", action = "index", id = UrlParameter.Optional },
                new [] { "UrlsAndRoutes.Controllers" });
        }
    }
}
