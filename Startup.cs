using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ProvinceCityWebApp.Startup))]
namespace ProvinceCityWebApp
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
