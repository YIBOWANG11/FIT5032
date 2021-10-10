using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Fit_5032_ass.Startup))]
namespace Fit_5032_ass
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
