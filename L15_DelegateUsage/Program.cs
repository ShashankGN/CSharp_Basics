namespace L15_DelegateUsage
{

    public delegate bool IsPromotable(Employee employee);
    internal class Program
    {
        static void Main(string[] args)
        {
            Employee[] employees = new Employee[3];
            employees[0] = new Employee { Id = 1, Name = "John", Salary = 5000, Experience = 2 };
            employees[1] = new Employee { Id = 2, Name = "Tina", Salary = 15000, Experience = 5 };
            employees[2] = new Employee { Id = 3, Name = "James", Salary = 50000, Experience = 10 };

            //static fuctions are called using the class name as the static functions are common to all instances


            IsPromotable isPromotable = new IsPromotable(PromoteEmployee);
            Employee.PromoteEmployee1(employees,isPromotable);
        }


        //one of the usage of delegate
        static bool PromoteEmployee(Employee employee)
        {
            if (employee.Salary > 10000)
                return true;

            return false;
        }
    }
}
