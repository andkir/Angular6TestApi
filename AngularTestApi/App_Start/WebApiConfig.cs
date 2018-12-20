using Newtonsoft.Json.Serialization;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;

namespace AngularTestApi
{
    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {
            HttpConfiguration config1 = GlobalConfiguration.Configuration;
            config1.Formatters.JsonFormatter.SerializerSettings.ContractResolver = new CamelCasePropertyNamesContractResolver();
            config1.Formatters.JsonFormatter.UseDataContractJsonSerializer = false;

            config.EnableCors();
            // Web API configuration and services

            // Web API routes
            config.MapHttpAttributeRoutes();

            config.Routes.MapHttpRoute(
                name: "DefaultApi",
                routeTemplate: "api/{controller}/{id}",
                defaults: new { id = RouteParameter.Optional }
            );
        }
    }
}
