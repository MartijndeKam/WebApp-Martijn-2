using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(WebApp_Martijn_2.Startup))]
namespace WebApp_Martijn_2
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
