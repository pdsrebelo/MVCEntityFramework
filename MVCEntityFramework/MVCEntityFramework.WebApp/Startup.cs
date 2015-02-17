using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MVCEntityFramework.WebApp.Startup))]
namespace MVCEntityFramework.WebApp
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
