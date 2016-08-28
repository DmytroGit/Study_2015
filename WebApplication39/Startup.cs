using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(WebApplication39.Startup))]
namespace WebApplication39
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
