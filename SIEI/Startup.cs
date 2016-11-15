using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(SIEI.Startup))]
namespace SIEI
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
