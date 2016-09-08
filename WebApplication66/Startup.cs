using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(WebApplication66.Startup))]
namespace WebApplication66
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
