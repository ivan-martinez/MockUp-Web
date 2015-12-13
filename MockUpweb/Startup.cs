using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MockUpweb.Startup))]
namespace MockUpweb
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
