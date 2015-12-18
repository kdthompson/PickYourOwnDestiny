using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(PickYourOwnDestiny.Startup))]
namespace PickYourOwnDestiny
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
