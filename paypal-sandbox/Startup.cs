using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(paypal_sandbox.Startup))]
namespace paypal_sandbox
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
