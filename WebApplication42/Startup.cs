using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(WebApplication42.Startup))]
namespace WebApplication42
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
