using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNet.Builder;
using Microsoft.AspNet.Hosting;
using Microsoft.AspNet.Http;
using Microsoft.Extensions.DependencyInjection;

namespace Test_App
{
    public class Startup
    {
        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit http://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app)
        {
            app.UseIISPlatformHandler();

            app.Run(async (context) =>
            {
                await context.Response.WriteAsync("  < h1 > Our Click2Cloud App</ h1 >");
                await context.Response.WriteAsync("  < h2 > Awesome App try it </ h2 >");
                await context.Response.WriteAsync("  < h3 > age.  It will usually be the largest text that stands out.  There are other header tags in HTML too, like an h2, h3, h4, etc.  Each can have a lesser degree of importance on the page, but it really depends on how your HTML/CSS guy did the layout.  Sometimes, they make your logo the h1 – because it’s in the “header”, but it would be best to make the </ h3 >");
                await context.Response.WriteAsync("  < h4 > age.  It will usually be the largest text that stands out.  There are other header tags in HTML too, like an h2, h3, h4, etc.  Each can have a lesser degree of importance on the page, but it really depends on how your HTML/CSS guy did the layout.  Sometimes, they make your logo the h1 – because it’s in the “header”, but it would be best to make the  </ h4 >");
                await context.Response.WriteAsync("  < h5 > age.  It will usually be the largest text that stands out.  There are other header tags in HTML too, like an h2, h3, h4, etc.  Each can have a lesser degree of importance on the page, but it really depends on how your HTML/CSS guy did the layout.  Sometimes, they make your logo the h1 – because it’s in the “header”, but it would be best to make the  </ h5 >");
                await context.Response.WriteAsync("Hello World!");
                await context.Response.WriteAsync("Hello World!");
                await context.Response.WriteAsync("Hello World!");
                await context.Response.WriteAsync("Hello World!");
                await context.Response.WriteAsync("Hello World!");
                await context.Response.WriteAsync("Hello World!");
                await context.Response.WriteAsync("Hello World!");
                await context.Response.WriteAsync("Hello World!");
                await context.Response.WriteAsync("Hello World!");
                await context.Response.WriteAsync("Hello World!");
            });
        }

        // Entry point for the application.
        public static void Main(string[] args) => WebApplication.Run<Startup>(args);
    }
}
