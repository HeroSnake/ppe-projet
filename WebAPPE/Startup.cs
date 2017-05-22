using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(WebAPPE.Startup))]
namespace WebAPPE
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
