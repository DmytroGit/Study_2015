using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(WebApplication55.Startup))]
namespace WebApplication55
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
