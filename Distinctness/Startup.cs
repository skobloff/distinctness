using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Distinctness.Startup))]
namespace Distinctness
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
