using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(WikiPOS.Startup))]
namespace WikiPOS
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
