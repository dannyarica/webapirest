using BasicApiResponse.App_Start;
using BasicApiResponse.Services;
using SimpleInjector;
using System.Web.Http;
using System.Web.Mvc;
using System.Web.Routing;

namespace BasicApiResponse
{
    public class WebApiApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            GlobalConfiguration.Configure(WebApiConfig.Register);

            var container = new Container();
            container.Register<IRateService, RateService>();
            container.Register<IUserService, UserService>();
            container.Register<IDeviceService, DeviceService>();
            container.Register<IDevicePhoneService, DevicePhoneService>();
            container.Register<IProductService, ProductService>();
            container.Register<IUserProductBankAccountService, UserProductBankAccountService>();
            container.Register<ITermsConditionsService, TermsConditionsService>();

            container.Verify();

            DependencyResolver.SetResolver(new SimpleInjectorDependencyResolver(container));
            GlobalConfiguration.Configuration.DependencyResolver = new SimpleInjectorDependencyResolver(container);
        }
    }
}