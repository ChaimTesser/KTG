using KTG.Areas.Setup.Models;
using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(KTG.Startup))]
namespace KTG
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
			Geocoder.Init();
            ConfigureAuth(app);
        }
    }
}
