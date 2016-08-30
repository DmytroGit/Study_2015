using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(WebApplication46.Startup))]
namespace WebApplication46
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
