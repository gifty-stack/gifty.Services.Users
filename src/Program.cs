using gifty.Services.Users.Bootstrappers;
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
                .WithAutofac(UsersServiceBootstrapper.BootstraperLifetimeScope)
                .WithNeo4j("bolt://localhost:7687", "neo4j", "test123")
                .WithRabbitMq("Users", "guest", "guest", 5672)
                .Build()
                .Run();
        }
    }
}
