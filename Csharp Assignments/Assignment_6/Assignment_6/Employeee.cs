using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_6
{
    class Employeee
    {
        public int EmpID { get; set; }

        public string EmpName { get; set; }

        public string EmpCity { get; set; }

        public double EmpSal { get; set; }


    }

    class Employee

    {
        static void Main()

        {

            Console.WriteLine("Enter List length:");

            int length = Convert.ToInt32(Console.ReadLine());

            List<Employeee> emplist = new List<Employeee> { };

            for (int i = 0; i < length; i++)

            {

                Console.WriteLine("Enter Employe ID:");

                int Employee_ID = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Enter Employe Name:");

                string Employee_Name = Console.ReadLine();

                Console.WriteLine("Enter Employe City:");

                string Employee_City = Console.ReadLine();

                Console.WriteLine("Enter Employe Salary:");

                double Employee_Salary = Convert.ToDouble(Console.ReadLine());

                emplist.Add(new Employeee
                {
                    EmpID = Employee_ID,

                    EmpName = Employee_Name,

                    EmpCity = Employee_City,

                    EmpSal = Employee_Salary
                });

            }

            Console.WriteLine("-----Details of All employees--------");

            foreach (var All in emplist)

            {

                Console.WriteLine("Employee ID:{0} Name: {1} City:{2} Salary:{3} ", All.EmpID, All.EmpName, All.EmpCity, All.EmpSal);

            }

            Console.WriteLine("----- Employees whose salary is greater than 45000--------");

            foreach (var emp in emplist)

            {

                if (emp.EmpSal > 45000)

                    Console.WriteLine(emp.EmpName);

            }

            Console.WriteLine("----- Employees data who belong to Bangalore Region are--------");

            foreach (var emp in emplist)

            {

                if (emp.EmpCity == "bengalore")

                    Console.WriteLine(emp.EmpName + "from" + emp.EmpCity);

            }

            IEnumerable<Employeee> Ascendingorder = emplist.OrderBy(n => n.EmpName);

            Console.WriteLine("----- Employees data by their names is Ascending order -------");

            foreach (var emp in Ascendingorder)

            {

                Console.WriteLine(emp.EmpName);

            }

            Console.ReadLine();

        }

    }
}

