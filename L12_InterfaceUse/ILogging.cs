using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L12_InterfaceUse
{
    internal interface ILogging
    {

        void Log(string message);
    }


    public class FileLogging : ILogging
    {
        public void Log(string message)
        {
            Console.WriteLine($"File log:{message}");
        }
    }

    public class ConsoleLogging : ILogging
    {
        public void Log(string message)
        {
            Console.WriteLine($"Console log:{message}");
        }
    }

    public class SQLLogging:ILogging
    {
        public void Log(string message)
        {
            Console.WriteLine($"SQL log:{message}");
        }
    }
}
