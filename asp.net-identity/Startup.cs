using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(asp.net_identity.Startup))]
namespace asp.net_identity
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
