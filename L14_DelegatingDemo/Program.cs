namespace L14_DelegatingDemo
{

    //Delegate is a type safe function pointer
    internal class Program
    {

        //function signature same as in interface
        //Delegate has a return type as void and an argument of type string which is according to Print Function so it can point only to Print function 
        //Delegate checks for the return type,number of arguments and the return type of arguments
        public delegate void GreetingDelegate(string message);

        //Delegate takes function as an argument
        static void Main(string[] args)
        {

            //to call the delegate of a non static function we have to create a object of Program class and call as program.Greet while the time of creation of Delegate object

            GreetingDelegate greetingDelegate = new GreetingDelegate(Greet);
            greetingDelegate("Delegate is ok from greeting");

            PrintDelegate printDelegate = new PrintDelegate(Print);
            printDelegate();
        }

        public delegate void PrintDelegate();
        static void Greet(string address)
        {
            Console.WriteLine(address);
        }

        static void Print()
        {
            Console.WriteLine("Delegate from print");
        }
    }

}
