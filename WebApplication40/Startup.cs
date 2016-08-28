using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(WebApplication40.Startup))]
namespace WebApplication40
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
