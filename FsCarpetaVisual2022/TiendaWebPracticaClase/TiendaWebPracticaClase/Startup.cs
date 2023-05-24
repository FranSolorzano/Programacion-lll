using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(TiendaWebPracticaClase.Startup))]
namespace TiendaWebPracticaClase
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
