using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(loja.Startup))]
namespace loja
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
