using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(WebApplication63.Startup))]
namespace WebApplication63
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
