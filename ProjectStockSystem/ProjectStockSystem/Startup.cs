using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ProjectStockSystem.Startup))]
namespace ProjectStockSystem
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
