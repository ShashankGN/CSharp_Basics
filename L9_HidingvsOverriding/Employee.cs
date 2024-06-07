using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L9_HidingvsOverriding
{
    public class Employee
    {
        public string fname = "John";
        public string lname = "Thomas";


        public void Print()
        {
            Console.WriteLine($"Fname:{fname},Lname:{lname}");
        }
    }

    public class Fullemployee : Employee
    {
        public new void Print()
        {
            Console.WriteLine($"Fname:{fname},Lname:{lname}--Fulltime");
        }
    }
}
//in method hiding base class reference variable pointing to child class object then it will invoke the hidden method in the base class(new keyword is used in child class method)


    //public class Employee
    //{
    //    public string fname = "John";
    //    public string lname = "Thomas";


    //    public virtual void Print()
    //    {
    //        Console.WriteLine($"Fname:{fname},Lname:{lname}");
    //    }
    //}

    //public class Fullemployee : Employee
    //{   
    //    public override void Print()
    //    {
    //        Console.WriteLine($"Fname:{fname},Lname:{lname}--Fulltime");
    //    }
    //}
//in method overriding base class reference variable pointing to child class object then it will invoke the method in the child class(virtual and override keywords are used)