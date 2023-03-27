﻿using ConsoleAppStrategy2x.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppStrategy2x.DataAccess
{
    public class SqLiteRemoteConnector : IDataAccess
    {
        internal string dbType = "SqLite";

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
