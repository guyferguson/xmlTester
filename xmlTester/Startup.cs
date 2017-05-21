using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(xmlTester.Startup))]
namespace xmlTester
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
