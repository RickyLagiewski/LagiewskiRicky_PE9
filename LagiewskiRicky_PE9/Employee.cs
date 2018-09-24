using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LagiewskiRicky_PE9
{
    class Employee
    {
        string name;
        string address;
        string jobTitle;
        int employeeNumber;
        int yearlySalary;
        //constructor
        public Employee()
        {
            name = "Employee";
            address = "123 Main Street";
            jobTitle = "Worker";
            employeeNumber = 00000;
            yearlySalary = 0;
        }
        //parameterized constructor
        public Employee(string p_name, string p_address, string p_jobTitle, int p_employeeNumber, int p_yearlySalary)
        {
            name = p_name;
            address = p_address;
            jobTitle = p_jobTitle;
            employeeNumber = p_employeeNumber;
            yearlySalary = p_yearlySalary;
        }
        //method
        public void ChangeName()
        {
            Console.WriteLine("\nWhat is the employee's name? ");
            name = Console.ReadLine();
        }
        //method 
        public void ChangeSalary()
        {
            Console.WriteLine("\nWhat is the new salary for the employee? ");
            yearlySalary = Console.Read();
        }
        //method
        public void PrintEmployee()
        {
            Console.WriteLine("Name: " + name);
            Console.WriteLine("Address: " + address);
            Console.WriteLine("Job Title: " + jobTitle);
            Console.WriteLine("Employee Number: " + employeeNumber);
            Console.WriteLine("Yearly Salary: " + yearlySalary);
        }

    }
}
