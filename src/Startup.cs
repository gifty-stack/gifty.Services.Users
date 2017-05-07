using gifty.Services.Users.Bootstrappers;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Nancy.Owin;

namespace gifty.Services.Users
{    
    public class Startup
    {
        public Startup(IHostingEnvironment env)
        {
            var builder = new ConfigurationBuilder()
                .SetBasePath(env.ContentRootPath)
                .AddJsonFile("appsettings.json", optional: true, reloadOnChange: true)
                .AddJsonFile($"appsettings.{env.EnvironmentName}.json", optional: true)
                .AddEnvironmentVariables();
            Configuration = builder.Build();
        }
        public IConfigurationRoot Configuration { get; }
        public IServiceCollection _services { get; private set; }

        public void ConfigureServices(IServiceCollection services)
        {
            _services = services;
        }

        public void Configure(IApplicationBuilder app)
        {
            app.UseOwin().UseNancy(x => x.Bootstrapper = new UsersServiceBootstrapper(_services, Configuration));
        }
    }
}
