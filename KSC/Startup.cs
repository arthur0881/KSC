using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(KSC.Startup))]
namespace KSC
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
