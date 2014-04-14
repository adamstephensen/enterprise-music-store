using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Northwind.MusicStore.WebUI.Startup))]
namespace Northwind.MusicStore.WebUI
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
