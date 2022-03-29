using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(children.Startup))]
namespace children
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
