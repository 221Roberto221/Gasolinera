using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Gasolinera.Startup))]
namespace Gasolinera
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
