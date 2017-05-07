using gifty.Services.Users.Bootstrappers;
using gifty.Shared.Builders;
using Neo4j.Driver.V1;

namespace gifty.Services.Users
{
    public class Program
    {
        public static void Main(string[] args)
        {
            ServiceBuilder
                .CreateDefault<Startup>()
                .WithPort(5001)
                .WithAutofac(UsersServiceBootstrapper.BootstraperLifetimeScope)
                .WithRabbitMq("Users", "guest", "guest", 5672)
                .Build()
                .Run();
        }
    }
}
