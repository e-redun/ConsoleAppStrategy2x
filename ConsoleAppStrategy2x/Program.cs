using ConsoleAppStrategy2x.DataAccess;
using ConsoleAppStrategy2x.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppStrategy2x
{
    class Program
    {
        static void Main(string[] args)
        {
            DataAccessHelper.InitializeConnector(DatabaseType.MsSQL, ComType.Local);

            DataAccessHelper.Connector.Read();

            DataAccessHelper.Connector.Write();


            DataAccessHelper.InitializeConnector(DatabaseType.SQLite, ComType.Remote);

            DataAccessHelper.Connector.Read();

            DataAccessHelper.Connector.Write();


        }
    }
}
