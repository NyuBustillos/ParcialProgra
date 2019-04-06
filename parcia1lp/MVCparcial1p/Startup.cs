using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MVCparcial1p.Startup))]
namespace MVCparcial1p
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
