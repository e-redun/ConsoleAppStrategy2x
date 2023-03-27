using ConsoleAppStrategy2x.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppStrategy2x.DataAccess
{
    public static class MsSqlConnectorFactory
    {
        public static IDataAccess CreateConnector(ComType comType)
        {
            IDataAccess output = null;

            switch (comType)
            {
                case ComType.Remote:
                    output = new MsSqlRemoteConnector();
                    break;
                case ComType.Local:
                    output = new MsSqlConnector();
                    break;

                default:
                    break;
            }

            return output;
        }
    }
}
