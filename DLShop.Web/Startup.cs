using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(DLShop.Web.Startup))]
namespace DLShop.Web
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
