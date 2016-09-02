using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(WebApplication54.Startup))]
namespace WebApplication54
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
