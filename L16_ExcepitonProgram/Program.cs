using System.ComponentModel.Design;
using System.Security.Principal;

namespace L16_ExcepitonProgram
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {

                //if(int.TryParse(Console.ReadLine(), out int firstNumber))
                //{

                //}    

                Console.WriteLine("Enter the first number");
                int firstNumber = Convert.ToInt32(Console.ReadLine());

                if(firstNumber== 0)
                {

                    //throw keyword is used when class is inheriting base class(useralreadyloggedinException is inheriting Exception class
                    throw new UserAlreadyLoggedInException("First number cannot be zero");
                }
                Console.WriteLine("Enter the first number");
                int seecondNumber = Convert.ToInt32(Console.ReadLine());


                int result = firstNumber / seecondNumber;

                Console.WriteLine($"Result id{result}");
            }
            //catch (FormatException ex)
            //{
            //    Console.WriteLine("invalid Input");
            //}

            //catch (OverflowException ex)
            //{
            //    Console.WriteLine("Input is too large");
            //}
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Logging.LogError(ex.StackTrace);//this will not be showed to the user
                Console.WriteLine(ex.Message);//onlt this will be showed to the user
                //Console.WriteLine(ex.StackTrace);

            }



            finally
            {
                //task to find why finally block is used
                //finally is used to release the resource
                //ex:when we are reading a file the file needs to be closed then it is closed in the finally block


            }

        }
    }

    class Logging
    {
        public static void LogError(string  message)
        {
            //write a logic to push it to a file server or sql server
        }
    }
}
