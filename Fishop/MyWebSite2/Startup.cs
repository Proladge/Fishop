using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MyWebSite2.Startup))]
namespace MyWebSite2
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
