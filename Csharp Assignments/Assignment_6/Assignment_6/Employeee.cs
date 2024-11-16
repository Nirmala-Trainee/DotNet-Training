using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_6
{
    class Employeee
    {
        public int EmpId { get; set; }
        public string EmpName { get; set; }
        public string EmpCity { get; set; }
        public double EmpSalary { get; set; }

        public Employeee(int eid, string ename, string ecity, double esal)
        {
            EmpId = eid;
            EmpName = ename;
            EmpCity = ecity;
            EmpSalary = esal;
        }

    }

    class program
    {
        private const string V = "Vizag";


        static void Main()
        {
            List<Employeee> emplist = new List<Employeee>()

            {
              new Employeee{101,"Arthi", V, 38000 },
              new Employeee{102,"Teja", V, 70000},
              new Employeee{103,"Kousalya","Hyderabad",32000 },
              new Employeee{104,"Nirmala","Banglore",35000 },
              new Employeee{105,"shwetha","Banglore",37000 },
              new Employeee{106,"Gowthami","Noida",39000}
            };
            var high_sal = emplist.FindAll(emp => emp.EmpSalary > 45000).ToList();
            Console.WriteLine("Details of people whose salary is greater than 45k");
            foreach (var employee in high_sal)
            {
                Console.WriteLine($"Id:{employee.EmpId},Name:{employee.EmpName},Location:{employee.EmpCity},Salary:{employee.EmpSalary}");
            }
            var Banglore_emp = emplist.Where(emp => emp.EmpCity == "Banglore").ToList();
            Console.WriteLine("Employees from Banglore are:");
            foreach (var employees in Banglore_emp)
            {
                Console.WriteLine($"Id:{employees.EmpId},Name:{employees.EmpName},Location:{employees.EmpCity},Salary:{employees.EmpSalary}");
            }
            var sort_emp = emplist.OrderBy(emps => emps.EmpName).ToList();
            Console.WriteLine("\n Sorted List Of Employees:  ");
            foreach (var emps in sort_emp)
            {
                Console.WriteLine($"Id:{emps.EmpId},Name:{emps.EmpName},Location:{emps.EmpCity},Salary:{emps.EmpSalary}");
            }

            Console.ReadLine();
        }
    }
}

