namespace L6_Staticdemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Circle firstCircle=new Circle(5);
            firstCircle.CalculateArea();

            Circle SecondCircle = new Circle(6);
            SecondCircle.CalculateArea();


            //Circle._pi = 3.14F;
        }
    }
}
