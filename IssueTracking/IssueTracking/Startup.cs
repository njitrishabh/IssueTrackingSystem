using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(IssueTracking.Startup))]
namespace IssueTracking
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
