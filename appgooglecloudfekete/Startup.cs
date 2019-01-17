using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(appgooglecloudfekete.Startup))]
namespace appgooglecloudfekete
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
