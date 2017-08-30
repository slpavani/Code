using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MVCAPI_Test.Startup))]
namespace MVCAPI_Test
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
