using System.Web.Http;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;
using SimpleInjector.Integration.Web.Mvc;
using SimpleInjector.Integration.WebApi;
using Teamify.Infrastructure;

namespace Teamify
{
    public class TeamifyApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            // Set the dependency resolver for MVC.
            var mvcContainer = IoCBootstrapper.GetMvcContainer();
            DependencyResolver.SetResolver(new SimpleInjectorDependencyResolver(mvcContainer));

            // Set the dependency resolver for Web API.
            var apiContainer = IoCBootstrapper.GetApiContainer();
            GlobalConfiguration.Configuration.DependencyResolver = new SimpleInjectorWebApiDependencyResolver(apiContainer);

            AreaRegistration.RegisterAllAreas();
            GlobalConfiguration.Configure(WebApiConfig.Register);
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);
        }
    }
}
