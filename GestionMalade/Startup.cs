using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(GestionMalade.Startup))]
namespace GestionMalade
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
