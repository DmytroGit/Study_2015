using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(WebApplication81.Startup))]
namespace WebApplication81
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
