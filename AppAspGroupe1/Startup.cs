using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(AppAspGroupe1.Startup))]
namespace AppAspGroupe1
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
