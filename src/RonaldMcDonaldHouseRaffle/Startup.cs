using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(RonaldMcDonaldHouseRaffle.Startup))]
namespace RonaldMcDonaldHouseRaffle
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
