namespace referencetype_and_valuetypeL4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            int fn = 10;
            Print(fn);
            Console.WriteLine(fn);
            int sn = 20;
            Print1(ref sn);
            Console.WriteLine(sn);
            int t = 0, p = 0;
            Calculate(5,5,out t,out p);
            Console.WriteLine($"Total={t},Product={p}");

        }

        static void Print(int num)
        {
            num = 20;
        }
        static void Print1(ref int num)
        {
            num = 30;
        }
        static void Calculate(int fn,int sn,out int sum,out int prod)
        {
            sum = fn + sn;
            prod = fn * sn;    
        }
    }
}
