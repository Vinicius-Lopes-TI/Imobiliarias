using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Imobiliarias.Startup))]
namespace Imobiliarias
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
