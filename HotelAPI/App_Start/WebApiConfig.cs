using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Web.Http;

namespace HotelAPI
{
    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {
            // Web API configuration and services

            // Web API routes
            config.MapHttpAttributeRoutes();



            config.Routes.MapHttpRoute(
                name: "DefaultApi",
                routeTemplate: "api/{controller}/{action}"
            );

            config.Routes.MapHttpRoute(
                name: "search",
                routeTemplate: "api/{controller}/{action}/{name}/{city}",
                defaults: new {city = RouteParameter.Optional}
            );

            config.Routes.MapHttpRoute(
                name:"add",
                routeTemplate: "api/{controller}/{action}/{GoścID}/{cena}/{Prowizja}/{Źródło}",
                defaults: new { Prowizja = RouteParameter.Optional, Źródło = RouteParameter.Optional }
                );

            config.Formatters.JsonFormatter.SupportedMediaTypes
                .Add(new MediaTypeHeaderValue("text/html"));
        }
    }
}
