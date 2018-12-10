using System;
using Neo4j.Driver.V1;



namespace Neo4J_DataImporter
{
    public class Neo4JConnector : IDisposable
    {
        private readonly IDriver dbDriver;

        public Neo4JConnector(string uri, string user, string password)
        {
            dbDriver = GraphDatabase.Driver(uri, AuthTokens.Basic(user, password));
        }
        
        internal void Ececute(string cypherQuery)
        {
            using (var session = dbDriver.Session())
            {
                session.WriteTransaction(tx =>
                {
                    tx.Run(cypherQuery);
                    
                });
                
            }
        }

        public void Dispose()
        {
            dbDriver?.Dispose();
        }
    }
}

