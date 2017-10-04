using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(VSGIT.Startup))]
namespace VSGIT
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
