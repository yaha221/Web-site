using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace MySite
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapMvcAttributeRoutes();

            routes.MapRoute(
                name: "Главный",
                url: "Главная",
                defaults: new { controller = "Home", action = "Index",}
            );
            routes.MapRoute(
                name: "Глава",
                url: "Глава",
                defaults: new { controller = "Home", action = "Index", }
            );
            routes.MapRoute(
                name: "Статья",
                url: "Статья",
                defaults: new { controller = "Home", action = "Index", }
            );
            routes.MapRoute(
                "Chapter",
                "Глава/{сhapterName}",
                new { controller = "Chapter", action = "GetNameChapter", }
            );
            routes.MapRoute(
                "Article",
                "Статья/{articleName}",
                new { controller = "Chapter", action = "GetNameChapter", }
            );
            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}",
                defaults: new { controller = "Home", action = "Index", }
            );
        }
    }
}
