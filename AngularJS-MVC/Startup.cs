using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(AngularJS_MVC.Startup))]
namespace AngularJS_MVC
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            // ConfigureAuth(app);
        }
    }
}
