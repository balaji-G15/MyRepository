using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(_2_WebFormApplication.Startup))]
namespace _2_WebFormApplication
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
