using Autofac;
using gifty.Shared.Nancy;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Nancy.Bootstrapper;
using Nancy.Bootstrappers.Autofac;

namespace gifty.Services.Users.Bootstrappers
{
    internal sealed class UsersServiceBootstrapper : BootstrapperBase
    {
        public UsersServiceBootstrapper(IServiceCollection services , IConfigurationRoot configurationRoot) 
            : base(services, configurationRoot)
        {
        }

        protected override void ConfigureApplicationContainer(ILifetimeScope container)
        { 
            container.Update(builder => 
            {
            });

            base.ConfigureApplicationContainer(container);
        }

        protected override void ApplicationStartup(ILifetimeScope container, IPipelines pipelines)
        { 
            base.ApplicationStartup(container, pipelines);
        }
    }
}