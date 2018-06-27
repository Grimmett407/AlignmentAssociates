using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(AlignmentAssociates.Startup))]
namespace AlignmentAssociates
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
