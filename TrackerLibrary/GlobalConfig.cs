using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrackerLibrary.DataAccess;

namespace TrackerLibrary
{
    public static class GlobalConfig
    {
        public static IDataConnection Connection { get; private set; }

        /// <summary>
        /// Initializes connections.
        /// </summary>
        /// <param name="database"></param>
        /// <param name="textFiles"></param>
        public static void InitializeConnections(DatabaseType db)
        {
            if (db == DatabaseType.Sql)
            {
                SQLConnector sql = new SQLConnector();
                Connection = sql;
            }
            else if (db == DatabaseType.TextFile)
            {
                // TODO - Create The Text Connection
                TextConnector text = new TextConnector();
                Connection = text;
            }
        }

        /// <summary>
        /// Reads and returns a connection string from the appsettings.json 
        /// configuration file.
        /// </summary>
        /// <param name="name">The name of the connection we want to establish.</param>
        /// <returns>The connection string.</returns>
        public static string CnnString(string name)
        {
            var builder = new ConfigurationBuilder()
                        .SetBasePath(Directory.GetCurrentDirectory())
                        .AddJsonFile(path: "appsettings.json", optional: false, reloadOnChange: true);
            IConfiguration config = builder.Build();

            var myConnectionString = config.GetConnectionString("db");
                       
            return myConnectionString;
        }

    }
}
 