using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace SimpleBlog
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");
            //var namespaces = new string[] { typeof(SimpleBlog.Controllers.PostsController).Namespace}; // Tells ASP.Net MVC where to find controller if names conflict

            routes.MapRoute("Login", "login", new { controller = "Auth", action = "Login" });
            routes.MapRoute("Logout", "logout", new { controller = "Auth", action = "Logout" });

            // There are two Posts controllers in this app, hence we need to tell ASP.Net the namespace to enable it figure right which Posts controller we meant
            // This is needed since ASP.Net flattens out all controllers in a list when running the ASP.Net MVC application
            routes.MapRoute("Home", "", new { controller = "Posts", action = "Index", id = UrlParameter.Optional }, new string[] { "SimpleBlog.Controllers" }); // Home page
        }
    } // class
}

//routes.MapRoute(
//    name: "Default",
//    url: "{controller}/{action}/{id}",
//    defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
//);