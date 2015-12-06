using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(HeroSaga.Startup))]
namespace HeroSaga
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
