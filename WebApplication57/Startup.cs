using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(WebApplication57.Startup))]
namespace WebApplication57
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
