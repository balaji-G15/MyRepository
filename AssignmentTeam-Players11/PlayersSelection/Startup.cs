using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(PlayersSelection.Startup))]
namespace PlayersSelection
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
