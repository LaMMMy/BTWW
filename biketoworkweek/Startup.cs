using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(biketoworkweeklogger.Startup))]
namespace biketoworkweeklogger
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
