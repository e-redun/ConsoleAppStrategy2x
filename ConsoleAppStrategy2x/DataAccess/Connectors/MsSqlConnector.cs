using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppStrategy2x.DataAccess
{
    public class MsSqlConnector : MsSqlRemoteConnector
    {
        public override void Read()
        {
            Console.WriteLine("Пишу в базу " + dbType + " - ТОЛСТЫЙ клиент"); ;
        }

        public override void Write()
        {
            Console.WriteLine("Читаю из базы " + dbType + " - ТОЛСТЫЙ клиент"); ;
        }
    }
}
