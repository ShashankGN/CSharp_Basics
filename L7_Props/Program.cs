namespace L7_Props
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Student student = new Student();
            //student.SetID(-1);
            //student.Setname("henry");

            //Console.WriteLine($"Id={student.GetID()},Name={student.Getname()},passmark={student.Getpassmark()}");

            student.Id = 1;
            Console.WriteLine(student.Id);


            var stud=new Student();
            var x = "hello";
            Display(5, num2: 30);
        }

        public static void Display(int y,string name="thomas", int num1=10,int num2=20)
        {
            Console.WriteLine(name);
        }

        //var cannot be used as Function arguments
    }
}
