namespace L13_Abstraction
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            Printer print=new Printer();
            Customer customer=new Customer();
            customer.Paper();
        }
    }


    //abstarct keyword is used for abstraction
    //objects of abstract class and interface cannot be created
    //by default if access specifier are not mentioned then the functions are private 
    //all functions of abstract class use override keyword
    //multiple class inheritance is not possible with abstract class
    //multiple interface inheritance is possible with abstract class
    //in interface the access specifier are public by default but in abstarct class it is private by default
    //string name;->field  
    //string name{ get; set;}->properties
    //in interface properties are possible but not fields
    //in abstract class field is possible
    abstract class Printer
    {
        public abstract void Print();

        public void Paper()
        {

        }
    }


    //Not possible
    //interface IPrinter:Printer
    //{

    //}

    interface IPrinter : Printer
    {
        public abstract string Color { get; set; }
    }



    class Customer : Printer
    {
        public override void Print()
        {
            Console.WriteLine("hi");
        }
    }

}
