using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L15_DelegateUsage
{
    public class Employee
    {

        public int Id { get; set; }
        public string Name { get; set; }    
        public int Experience {  get; set; }
        public int Salary {  get; set; }

        public static void PromoteEmployee1(Employee[] employees,IsPromotable ispromotable)
        {
            foreach (Employee emp in employees)
            {
                if(ispromotable(emp))
                {
                    Console.WriteLine(emp.Name);
                }
                
            }
        }
    }
}
