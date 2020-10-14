using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(keenMVC.Startup))]
namespace keenMVC
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
