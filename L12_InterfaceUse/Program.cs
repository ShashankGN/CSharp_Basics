namespace L12_InterfaceUse
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //ILogging filelog = new FileLogging();
            //filelog.Log("This is file message");

           ILogging consolelog= new ConsoleLogging();
            //consolelog.Log("This is Console message");

            ILogging filelog= new FileLogging();


            Customer customer = new Customer(consolelog);
            customer.Id = 1;
            customer.Name = "Test";

            customer.LogMessage();

            Person person = new Person("John");
            person.Print();



            UST uST = new UST();    
            uST.Id = 1;
        }
    }

    class Person
    {
        string name;

        public Person(string name)
        {
            //When datamember and parameter is same we have to use the this keyword
            this.name = name;
        }

        public void Print()
        {

            Console.WriteLine($"Name:{name}");
        }
    }


    //sealed class Company
    //{
    //    public int Id { get; set; }

    //    string Name { get; set; }
    //}
    //keyword sealed makes the class not to be inherited
    //it is possible to create an object of a sealed class

    class Company
    {
        Company()
        {

        }
        public int Id { get; set; }

        string Name { get; set; }
    }
    //if the class is sealed and do not want the class to be inherited then we have to make the constructor of the class as private
    //object of a class cannot be created if its constructor is private

    class UST:Company
    {

    }
}
