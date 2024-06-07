using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L8_Inheritance
{
    public class Employee : Object
    {
        public string fname="john";
        public string lname="thomas";

        //public Employee() {
        //    Console.WriteLine("I am base cnstructor");
        //}
        //static Employee()
        //{
        //    Console.WriteLine("I am static base cnstructor");
        //}

        public virtual void PrintFullname()
        {
            Console.WriteLine($"Firstname:{fname},Lastname:{lname}");

        }
    }

    //internal class PartEmployee : Employee
    //{
    //    public float salary;
    //}

    internal class FullEmployee : Employee
    {
        public float hourrate;
        //public FullEmployee()
        //{
        //    Console.WriteLine("i am child constructor");
        //}

        //static FullEmployee()
        //{
        //    Console.WriteLine("i am static child constructor");
        //}

        public override void PrintFullname()
        {
            //base.PrintFullname();
            Console.WriteLine($"Firstname:{fname},Lastname:{lname}--FullTime");

        }
    }

    public class PartEMployee:Employee
    {
        public override void PrintFullname()
        {
            //base.PrintFullname();
            Console.WriteLine($"Firstname:{fname},Lastname:{lname}--PartTime");

        }
    }

    public class TempEmployee:Employee
    {
        public override void PrintFullname()
        {
            //base.PrintFullname();
            Console.WriteLine($"Firstname:{fname},Lastname:{lname}--TempTime");

        }
    }
}
