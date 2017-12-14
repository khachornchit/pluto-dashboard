using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Pluto.Site.Startup))]
namespace Pluto.Site
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
