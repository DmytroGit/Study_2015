using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(WebApplication41.Startup))]
namespace WebApplication41
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
