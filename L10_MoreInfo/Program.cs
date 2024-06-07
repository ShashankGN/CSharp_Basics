namespace L10_MoreInfo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //one way of initializing objects
            //Customer cus = new Customer();
            //cus.Id = 1;
            //cus.Name = "John";

            //another way of initializing objects
            Customer customer = new Customer
            {
                Id = 1,
                Name = "John"
            };


            //default value of the object is namespace i.e the projectname followed by a dot followed by the class name
            Console.WriteLine(customer);


            Person person = new Person { id = 1, name = "Thomas" };
            //to demonstrate how the struct is a value and class is a reference type
            Person per = person;
            per.name = "John";
            per.Print();



            Display();
        }

        static void Display()
        {
            int x = 10;
            Person person = new Person();
        }
    }

    //by default every class inherits the object class
    //class Customer
    //{
    //    public int Id { get; set; }
    //    //Required keyword makes it manadotory to initialize this field to the object
    //    public required string Name { get; set; }




    //    //In order to overcome the default value of object 
    //    //public override string ToString()
    //    //{
    //    //    return $"ID is {Id},Name is {Name}";
    //    //}
    //}
}
