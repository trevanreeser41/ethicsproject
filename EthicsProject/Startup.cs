using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(EthicsProject.Startup))]
namespace EthicsProject
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
