using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LagiewskiRicky_PE9
{
    class Program
    {
        static void Main(string[] args)
        {
            //creating object
            Employee myCustomeEmployee = new Employee("Ricky", "123 XD", "Meme lord", 69, 12);
            //printing employee
            myCustomeEmployee.PrintEmployee();
            Console.WriteLine("\n");
            //changing name
            myCustomeEmployee.ChangeName();
            Console.WriteLine("\n");
            //chaning salary
            myCustomeEmployee.ChangeSalary();
            Console.WriteLine("\n");
            //printing again
            myCustomeEmployee.PrintEmployee();
        }
    }
}
