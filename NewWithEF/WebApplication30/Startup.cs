using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(WebApplication30.Startup))]
namespace WebApplication30
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
