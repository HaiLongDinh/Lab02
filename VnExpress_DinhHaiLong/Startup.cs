using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(VnExpress_DinhHaiLong.Startup))]
namespace VnExpress_DinhHaiLong
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
