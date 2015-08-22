using Microsoft.Owin;
using Owin;
using SimpleDemo;

[assembly: OwinStartup(typeof(Startup))]

namespace SimpleDemo
{
    public class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            app.MapSignalR();
        }
    }
}
