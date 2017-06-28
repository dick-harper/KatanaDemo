using System.Web;
using Owin;

namespace KatanaDemo.Api
{
    public class Startup
    {
        public void Configuration(IAppBuilder app)
        {

            app.Use<Logger>();

            //app.UseWelcomePage();

            //app.Run(ctx =>
            //{
            //    return ctx.Response.WriteAsync("Hello Katana");
            //});
        }
    }
}