using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L6_Staticdemo
{
    internal class Circle
    {
        int _radius;
        //static->memory will be created only once
        //data member with static should be called without this keyword since it does not belong to particular instance(object)
        static float _pi;


        //static constructors are used to initialize static members
        //access modifiers are not allowed for static constructors
        //static functions are called directly without the use of objects
        //for static constructors we cannot pass parameters
        //static constructors are called only once and static members are initilized only once
        //static members cannot be accessed using instances(objects)
        //by default that is wihtout mentioning the access specifier the access specifier is private for static
        //if static members are private we cannot change it using classname.datamember, if static members are public we can change it using classname.datamember
        //static members have a common (only one) memory location for all the instances of the class
        //static constructors are called only once and the memory is allocated to it only once that too only when an instance of the class is created or it is called accessed through the class name
        //there are two ways of allocating memory to static members,one is through static cosntructor and the other way is making it public and assigning value to it by accessing it through class name 
        static Circle()
        {
            _pi = 3.14F;
            Console.WriteLine("I am Static constructor");
        }
        public Circle(int radius)
        {
            _radius = radius;
            Console.WriteLine("I am Instance constructor");         
        }
        public void CalculateArea()
        {
            float area=_pi*this._radius*this._radius;
            Console.WriteLine($"Area is {area}");
        }
    }
}
