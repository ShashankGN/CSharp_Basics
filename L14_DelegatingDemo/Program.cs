namespace L14_DelegatingDemo
{

    //Everything in C# is inherited by object class

    


    //Delegate is a type safe function pointer
    internal class Program
    {

        //function signature same as in interface
        //Delegate has a return type as void and an argument of type string which is according to Print Function so it can point only to Print function 
        //Delegate checks for the return type,number of arguments and the return type of arguments
        public delegate void GreetingDelegate(string message);


        //Multicast delegate->It has reference to more than one function
        public delegate void MethodDelegate();


        public delegate int NumberDelegate();
        //Delegate takes function as an argument
        static void Main(string[] args)
        {

            //to call the delegate of a non static function we have to create a object of Program class and call as program.Greet while the time of creation of Delegate object

            GreetingDelegate greetingDelegate = new GreetingDelegate(Greet);
            greetingDelegate("Delegate is ok from greeting");

            //PrintDelegate printDelegate = new PrintDelegate(Print);
           //printDelegate();


            //Mutlicast delegate usage
            MethodDelegate methoddelegateOne= new MethodDelegate(MethodOne);
            MethodDelegate methoddelegateTwo = new MethodDelegate(MethodTwo);
            MethodDelegate methoddelegateThree = new MethodDelegate(MethodThree);
            methoddelegateOne();
            methoddelegateTwo();
            methoddelegateThree();

            //alternate way for the usage of the multicast delegate
            MethodDelegate methoddelegateFour=methoddelegateOne+methoddelegateTwo+methoddelegateThree;
            methoddelegateFour();


            //Another way for the usage of multicast delegate
            //MethodDelegate methodDelegate = new MethodDelegate(MethodOne);
            //methodDelegate += MethodTwo;
            //methodDelegate += MethodThree;
            //methodDelegate();


            MethodDelegate methodDelegate = new MethodDelegate(MethodOne);
            methodDelegate += MethodTwo;
            methodDelegate += MethodThree;
            methodDelegate -= MethodOne;
            methodDelegate();


            NumberDelegate numberdelegate = new NumberDelegate(GetFirstNumber);
            int res = numberdelegate();
            Console.WriteLine(res);

            NumberDelegate numberdelegate1=new NumberDelegate(GetFirstNumber);
            numberdelegate1 += GetSecondNumber;
            int res1 = numberdelegate1();
            Console.WriteLine(res1);




        }
        static int GetFirstNumber()
        {
            return 1;
        }

        static int GetSecondNumber()
        {
            return 2;
        }

        public delegate void PrintDelegate();
        static void Greet(string address)
        {
            Console.WriteLine(address);
        }

        //static void Print()
        //{
        //    Console.WriteLine("Delegate from print");
        //}

        static void MethodOne()
        {
            Console.WriteLine("Method One");
        }
        static void MethodTwo()
        {
            Console.WriteLine("Method two");
        }
        static void MethodThree()
        {
            Console.WriteLine("Method three");
        }
    }

}
