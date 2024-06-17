namespace L16_Cont.ExceptionProgram
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                try
                {
                    Console.WriteLine("Enter the first number:");
                    int firstNumber = Convert.ToInt32(Console.ReadLine());

                    if (firstNumber == 0)
                    {
                        throw new Exception("First number cannot be zero");
                    }
                }
                catch(Exception ex)
                {
                    throw new Exception("User exception", ex);
                }
            }
            catch(Exception ex)
            {
                Console.WriteLine($"Inner exception:{ex.InnerException.Message}");
                Console.WriteLine(ex.Message);
            }
        }
    }
}
