using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppStrategy2x.DataAccess
{
    public interface IDataAccess
    {
        void Read();

        void Write();
    }
}
