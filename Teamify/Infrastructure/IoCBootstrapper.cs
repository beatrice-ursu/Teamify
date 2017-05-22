using System.Collections.Generic;
using System.Web;
using System.Web.Http;
using Microsoft.AspNet.Identity;
using Microsoft.Owin;
using Microsoft.Owin.Security;
using Microsoft.Owin.Security.DataProtection;
using SimpleInjector;
using SimpleInjector.Advanced;
using SimpleInjector.Integration.Web;
using SimpleInjector.Lifestyles;
using Teamify.DL;
using Teamify.DL.Entities;

namespace Teamify.Infrastructure
{
    public static class IoCBootstrapper
    {
        public static Container GetMvcContainer()
        {
            var mvcContainer = new Container();
            mvcContainer.Options.DefaultScopedLifestyle = new WebRequestLifestyle();
            
            RegisterComponents(mvcContainer);

            mvcContainer.RegisterMvcControllers(typeof(TeamifyApplication).Assembly);

            mvcContainer.Verify();

            return mvcContainer;
        }

        public static Container GetApiContainer()
        {
            var apiContainer = new Container();
            apiContainer.Options.DefaultScopedLifestyle = new AsyncScopedLifestyle();

            RegisterComponents(apiContainer);

            apiContainer.RegisterWebApiControllers(GlobalConfiguration.Configuration, typeof(TeamifyApplication).Assembly);

            apiContainer.Verify();

            return apiContainer;
        }

        private static void RegisterComponents(Container container)
        {
            container.Register<ApplicationDbContext>(Lifestyle.Scoped);
            container.Register<IUserStore<User>, ApplicationUserStore>(Lifestyle.Scoped);
            container.Register<ApplicationUserManager>(Lifestyle.Scoped);
            container.Register<ApplicationSignInManager>(Lifestyle.Scoped);
            container.Register<IAuthenticationManager>(
                () => container.IsVerifying()
                    ? new OwinContext(new Dictionary<string, object>()).Authentication
                    : HttpContext.Current.GetOwinContext().Authentication, Lifestyle.Scoped);
            container.Register<IDataProtectionProvider>(() => new DpapiDataProtectionProvider("Teamify Identity​"), Lifestyle.Scoped);
        }
    }
}