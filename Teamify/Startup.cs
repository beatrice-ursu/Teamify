using System.Web.Http;
using System.Web.Mvc;
using Microsoft.Owin;
using Owin;
using SimpleInjector.Integration.Web.Mvc;
using SimpleInjector.Integration.WebApi;
using SimpleInjector.Lifestyles;
using Teamify.Infrastructure;

[assembly: OwinStartup(typeof(Teamify.Startup))]
namespace Teamify
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        { 
            ConfigureAuth(app);
        }
    }
}
