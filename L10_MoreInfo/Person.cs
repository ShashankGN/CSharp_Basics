using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L10_MoreInfo
{
    public struct Person
    {
        public int id {  get; set; }
        public string name { get; set; }

        public Person(int id, string name)
        {
            this.id = id;
            this.name = name;   
        }


        public void Print()
        {
            Console.WriteLine($"Id {id},Name {name}");
        }
    }

    class Customer
    {
        public int Id { get; set; }
        //Required keyword makes it manadotory to initialize this field to the object
        public required string Name { get; set; }




        //In order to overcome the default value of object 
        public override string ToString()
        {
            return $"ID is {Id},Name is {Name}";
        }
    }
}
