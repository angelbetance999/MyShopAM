using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MyShopAM.WebUI.Startup))]
namespace MyShopAM.WebUI
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
