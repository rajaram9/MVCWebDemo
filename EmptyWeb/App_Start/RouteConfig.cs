using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace EmptyWeb
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");
            //routes.IgnoreRoute("{resource}.aspx/{*pathInfo}");
            //routes.IgnoreRoute("{resource}.ashx/{*pathInfo}");

            routes.IgnoreRoute("{resource}.aspx/{*pathInfo}");
            routes.IgnoreRoute("{handler}.ashx/{*pathInfo}");
            routes.IgnoreRoute("ajaxpro/prototype.ashx");
            routes.IgnoreRoute("ajaxpro/core.ashx");
            routes.IgnoreRoute("ajaxpro/converter.ashx");
            routes.IgnoreRoute("ajaxpro/{resource}.ashx");

            routes.IgnoreRoute("{resource}.asmx/{*pathInfo}");

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}