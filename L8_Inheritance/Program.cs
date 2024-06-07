namespace L8_Inheritance
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Employee employee = new Employee();
            //employee.PrintFullname();

            //FullEmployee fullEmployee = new FullEmployee();

            //Employee fullemployee1 = new Employee();
            //fullEmployee.fname = "john";
            //fullEmployee.lname = "thomas";
            //fullEmployee.PrintFullname();

            //((Employee)fullEmployee).PrintFullname();

            Employee[] employees = new Employee[4];
            employees[0] = new Employee();
            employees[1] = new FullEmployee();
            employees[2] = new PartEMployee();
            employees[3]= new TempEmployee();   


            foreach(Employee employee in employees)
            {
                employee.PrintFullname();
            }
        }
    }
}
