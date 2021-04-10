using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(CCPM.Startup))]
namespace CCPM
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
