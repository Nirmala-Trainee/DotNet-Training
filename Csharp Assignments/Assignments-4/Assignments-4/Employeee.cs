using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_4
{
    class Employee_details
    {
        public int EmpId;
        public string EmpName;
        public float Salary;

        public Employee_details(int empid, string ename, float salary)
        {
            EmpId = empid;
            EmpName = ename;
            Salary = salary;
        }
        public void Display()
        {
            Console.WriteLine("Employee Id: {0} , Employee Name: {1} , Salary: {2}", EmpId, EmpName, Salary);
        }

    }
    class PartTimeEmployee : Employee_details
    {
        int Wages;

        public PartTimeEmployee(int empid, string ename, float salary) : base(empid, ename, salary)
        {

        }

        public static void Main()
        {
            Console.WriteLine("Enter the Employee Id");
            int id = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the Employee Name");
            string name = Console.ReadLine();
            Console.WriteLine("Enter the Employee salary");
            float sal = (float)Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("----Through Base class Constructor and object----");
            Employee_details e1 = new Employee_details(id, name, sal);
            e1.Display();
            Console.WriteLine("----Through Base class Constructor and object----");
            PartTimeEmployee p1 = new PartTimeEmployee(id, name, sal);
            p1.Display();
            Console.Read();
        }
    }
}
