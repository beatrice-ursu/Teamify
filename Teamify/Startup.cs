using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Teamify.Startup))]
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
