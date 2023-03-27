using ConsoleAppStrategy2x.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppStrategy2x.DataAccess
{
    public class MsSqlRemoteConnector : IDataAccess
    {
        internal string dbType = "MsSQL";

        public virtual void Read()
        {
            Console.WriteLine("Пишу в базу " + dbType + " - Тонкий клиент"); ;
        }

        public virtual void Write()
        {
            Console.WriteLine("Читаю из базы " + dbType + " - Тонкий клиент"); ;
        }
    }
}
