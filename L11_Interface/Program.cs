namespace L11_Interface
{

    //I is coding covention which tells that it is a interface
    interface ICustomerOne
    {
        //by default all the methods in interface are public
        void Print();

    }

    interface ICustomerTwo
    {
        //void PrintCustomerTwo();
        void Print();
    }

    //Multiple class inheritance in C# is not possible
    //Multiple interface inheritance in C# is possible

    class Customer : ICustomerOne, ICustomerTwo
    {
        //public void Print()
        //{
        //    Console.WriteLine("Print Customer one");
        //}

        //public void PrintCustomerTwo()
        //{
        //    Console.WriteLine("printCustomer Two");
        //}

        
        void ICustomerOne.Print()
        {
            Console.WriteLine("Icustomerone");
        }

        public void Print()
        {
            Console.WriteLine("Print Customer one");
        }
        void ICustomerTwo.Print()
        {
            Console.WriteLine("Icustomertwo");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            Customer customer = new Customer();
            customer.Print();
            //customer.PrintCustomerTwo();

            //(ICustomerOne)customer).Print();
            //(ICustomerTwo)customer).Print();


            ICustomerTwo customerTwo = new Customer();
            customerTwo.Print();
        }
    }
}
