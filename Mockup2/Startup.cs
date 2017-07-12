using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Mockup2.Startup))]
namespace Mockup2
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
