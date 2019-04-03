using BasicApiResponse.Delegates;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;
using Newtonsoft.Json.Serialization;

namespace BasicApiResponse
{
    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {
            //web api routes
            config.MapHttpAttributeRoutes();

            config.Routes.MapHttpRoute(
                name: "DefaultController",
                routeTemplate: "",
                defaults: new { controller = "Home" }
            );

            config.Routes.MapHttpRoute(
                name: "ErrorController",
                routeTemplate: "{*url}",
                defaults: new { controller = "Error" }
            );

            //formatters
            var jsonFormatter = config.Formatters.JsonFormatter;
            jsonFormatter.SerializerSettings = new Newtonsoft.Json.JsonSerializerSettings
            {
                Formatting = Newtonsoft.Json.Formatting.None,
                ContractResolver = new CamelCasePropertyNamesContractResolver(),
                NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore
            };

            //message handlers
            config.MessageHandlers.Add(new ApiResponseDelegate());
        }
    }
}
