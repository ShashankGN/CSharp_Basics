using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;




namespace L12_InterfaceUse
{
    internal class Customer
    {
        public int Id { get; set; }
        public string Name { get; set; }

        ILogging _logging;
        public Customer(ILogging logging) { 
            _logging = logging;
        }


        //parent reference variable can point to a child object
        public void LogMessage()
        {
            _logging.Log($"{Id},{Name}");
        }
    }
}
