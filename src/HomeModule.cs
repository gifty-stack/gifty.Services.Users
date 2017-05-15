namespace gifty.Services.Users
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using Nancy;
    using Neo4j.Driver.V1;

    public class HomeModule : NancyModule
    {
        public HomeModule()
        {
            Get("/", _ => 
            {
                using(var driver = GraphDatabase.Driver( "bolt://localhost:7687", AuthTokens.Basic("neo4j", "test123"), Config.DefaultConfig))
                    using(var session = driver.Session())
                    {
                        var result = session.Run("MATCH (a:Actor)-[:ACTS_IN]->(:Movie{title:'Avatar'}) RETURN a.name AS name");

                        foreach(var node in result)
                        {
                            Console.WriteLine(node["name"].As<string>());
                        }

                        return 2;
                    } 
            });
        }
    }
}
