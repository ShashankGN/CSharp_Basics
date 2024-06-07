using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L5_Class
{
    public class Customer
    {
        string _fname;
        string _lname;
        public Customer():this("NO FN","NO LN")
        {
            
        }
        public Customer(string fname,string lname)
        {
            _fname = fname; 
            _lname = lname; 
        }
        public void Printfull()
        {
        Console.WriteLine($"Full name is {_fname},{_lname}");
        }
    }
}
