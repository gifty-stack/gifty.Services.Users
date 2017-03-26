using gifty.Services.Users.IoC;
using gifty.Shared.Builders;

namespace gifty.Services.Users
{
    public class Program
    {
        public static void Main(string[] args)
        {
            ServiceBuilder
                .CreateDefault<Startup>()
                .WithPort(5001)
                .WithAutofac(AutofacRegistration.RegisterUsersService)
                .WithRabbitMq("Users", "guest", "guest", 5672)
                .Build()
                .Run();
        }
    }
}
