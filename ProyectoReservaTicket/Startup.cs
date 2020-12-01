using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ProyectoReservaTicket.Startup))]
namespace ProyectoReservaTicket
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
