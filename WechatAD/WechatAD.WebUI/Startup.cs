using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(WechatAD.WebUI.Startup))]
namespace WechatAD.WebUI
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
