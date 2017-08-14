using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MusicGigApplication.Startup))]
namespace MusicGigApplication
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
