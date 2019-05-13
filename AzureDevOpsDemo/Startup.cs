using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(AzureDevOpsDemo.Startup))]
namespace AzureDevOpsDemo
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
