using ConsoleAppStrategy2x.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppStrategy2x.DataAccess
{
    public static class DataAccessHelper
    {
        public static IDataAccess Connector;

        public static void InitializeConnector(DatabaseType databaseType, ComType comType)
        {

            switch (databaseType)
            {
                case DatabaseType.MsSQL:
                    Connector = MsSqlConnectorFactory.CreateConnector(comType);
                    break;
                
                case DatabaseType.SQLite:
                    Connector = SqLiteConnectorFactory.CreateConnector(comType);
                    break;
                
                case DatabaseType.PostGRE:
                    break;
             
                default:
                    break;
            }
        }
    }
}