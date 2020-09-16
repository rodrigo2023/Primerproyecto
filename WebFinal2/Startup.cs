using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(WebFinal2.Startup))]
namespace WebFinal2
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
