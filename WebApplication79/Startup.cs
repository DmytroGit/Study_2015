using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(WebApplication79.Startup))]
namespace WebApplication79
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
