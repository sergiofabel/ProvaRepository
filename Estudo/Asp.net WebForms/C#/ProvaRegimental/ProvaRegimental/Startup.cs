using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ProvaRegimental.Startup))]
namespace ProvaRegimental
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
