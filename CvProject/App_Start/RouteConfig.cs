using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace CvProject
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
                name: "Egitim",
                url: "egitim-hayatim",
                defaults: new { controller = "Education", action = "Index" }
            );

            routes.MapRoute(
                name: "Yeteneklerim",
                url: "yeteneklerim",
                defaults: new { controller = "Skill", action = "Index" }
            );

            routes.MapRoute(
                name: "Hakkımda",
                url: "hakkimda",
                defaults: new { controller = "About", action = "Index" }
            );

            routes.MapRoute(
                name: "Deneyimlerim",
                url: "deneyimlerim",
                defaults: new { controller = "Experience", action = "Index" }
            );

            routes.MapRoute(
                name: "Hobilerim",
                url: "hobilerim",
                defaults: new { controller = "Interest", action = "Index" }
            );

            routes.MapRoute(
                name: "Sertifikalarım",
                url: "sertifikalarim",
                defaults: new { controller = "Award", action = "Index" }
            );

            routes.MapRoute(
                name: "Iletisim",
                url: "iletisim",
                defaults: new { controller = "Contact", action = "Index" }
            );

            routes.MapRoute(
                name: "SosyalMedya",
                url: "sosyal-medyam",
                defaults: new { controller = "SocialMedia", action = "Index" }
            );

            routes.MapRoute(
                name: "Giris",
                url: "giris-yap",
                defaults: new { controller = "Login", action = "Index" }
            );

            routes.MapRoute(
                name: "Cıkıs",
                url: "cikis-yap",
                defaults: new { controller = "Login", action = "LogOut" }
            );


            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Default", action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}
