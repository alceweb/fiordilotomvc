using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(FiordilotoMVC.Startup))]
namespace FiordilotoMVC
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
