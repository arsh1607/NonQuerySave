using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(CloudinarySample.Startup))]
namespace CloudinarySample
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
