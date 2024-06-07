namespace DataconversionL2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            double a = 10.21;
            int b=(int)a;  
            Console.WriteLine($"b is{b}");   

            int c=Convert.ToInt32(a);
            Console.WriteLine($"c is {c}");

            int num = 500;
            byte number=(byte)num;
            Console.WriteLine($"Byte number is {number}");

            string n = "12345";
            int numb=int.Parse(n);
            Console.WriteLine(numb);


            string n1 = "12345abcd";
            //int numb1=int.Parse(n1);    
            //Console.WriteLine(numb1);
            //the above to line gives error because of the parse return type which is int which cannot convert abcd
            int result;
            bool canbe=int.TryParse(n1 , out result);
            if( canbe)
            {
                Console.WriteLine($"value is {result}");
            }
            else
            {
                Console.WriteLine("Invalid input");
                Console.WriteLine($"value is {result}");
            }
        }

    }
}
