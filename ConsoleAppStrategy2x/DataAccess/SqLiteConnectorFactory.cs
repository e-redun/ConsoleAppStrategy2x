using ConsoleAppStrategy2x.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppStrategy2x.DataAccess
{
    public static class SqLiteConnectorFactory
    {
        public static IDataAccess CreateConnector(ComType comType)
        {
            IDataAccess output = null;

            switch (comType)
            {
                case ComType.Remote:
                    output = new SqLiteRemoteConnector();
                    break;

                case ComType.Local:
                    output = new SqLiteConnector();
                    break;

                default:
                    break;
            }
            return output;
        }
    }
}
