using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(gitEvo.Startup))]
namespace gitEvo
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
