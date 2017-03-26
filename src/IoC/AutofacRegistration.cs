using Autofac;

namespace gifty.Services.Users.IoC
{
    internal static class AutofacRegistration
    {
        internal static ContainerBuilder RegisterUsersService(ContainerBuilder containerBuilder)
        {
            return containerBuilder;
        } 
    }
}