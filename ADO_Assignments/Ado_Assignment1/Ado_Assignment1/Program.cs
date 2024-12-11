using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ado_Assignment1
{
    class Employee
    {
        public int EmployeeID;
        public string FirstName;
        public string LastName;
        public string Title;
        public DateTime DOB;
        public DateTime DOJ;
        public string City;
    }
    class Program
    {
        static void Main(string[] args)
        {
            var employees = new List<Employee>
              {
                new Employee { EmployeeID = 1001, FirstName = "Malcolm", LastName = "Daruwalla",Title = "Manager", DOB = new DateTime(1984, 11, 16), DOJ = new DateTime(2011, 6, 8), City = "Mumbai" },
                new Employee { EmployeeID = 1002, FirstName = "Asdin", LastName = "Dhalla",Title = "AsstManager", DOB = new DateTime(1984, 8, 20), DOJ = new DateTime(2012, 7, 7), City = "Mumbai"},
                new Employee { EmployeeID = 1003, FirstName = "Madhavi", LastName = "Oza",Title = "Consultant", DOB = new DateTime(1987, 11, 14), DOJ = new DateTime(2015, 4, 12), City = "Pune" },
                new Employee { EmployeeID = 1004, FirstName = "Saba", LastName = "Shaikh",Title = "SE", DOB = new DateTime(1990, 6, 3), DOJ = new DateTime(2016, 2, 2), City = "Pune" },
                new Employee { EmployeeID = 1005, FirstName = "Nazia", LastName = "Shaikh",Title = "SE", DOB = new DateTime(1991, 3, 8), DOJ = new DateTime(2016, 2, 2), City = "Mumbai" },
                new Employee { EmployeeID = 1006, FirstName = "Amit", LastName = "Pathak",Title = "Consultant", DOB = new DateTime(1989, 11, 7), DOJ = new DateTime(2014, 8, 8), City = "Chennai" },
                new Employee { EmployeeID = 1007, FirstName = "Vijay", LastName = "Natrajan",Title = "Consultant", DOB = new DateTime(1989, 12, 2), DOJ = new DateTime(2015, 6, 1), City = "Mumbai" },
                new Employee { EmployeeID = 1008, FirstName = "Rahul", LastName = "Dubey",Title = "Associate", DOB = new DateTime(1993, 11, 11), DOJ = new DateTime(2014, 11, 6), City = "Chennai" },
                new Employee { EmployeeID = 1009, FirstName = "Suresh", LastName = "Mistry",Title = "Associate", DOB = new DateTime(1992, 8, 12), DOJ = new DateTime(2014, 12, 3), City = "Chennai" },
                new Employee { EmployeeID = 1010, FirstName = "Sumit", LastName = "Shah",Title = "Manager", DOB = new DateTime(1991, 4, 12), DOJ = new DateTime(2016, 1, 2), City = "Pune" }
            };

            //1.Display a list of all the employee who have joined before 1 / 1 / 2015
            Console.WriteLine("-----------Display a list of all the employee who have joined before 1 / 1 / 2015------------");
            var emp1 = employees.Where(e => e.DOJ < new DateTime(2015, 1, 1)).Select(n => n);
            foreach (var i in emp1)
            {
                Console.WriteLine($" Employee Name : {i.FirstName}{i.LastName} , DOJ : {i.DOJ.ToShortDateString()}");
            }

            //2. Display a list of all the employee whose date of birth is after 1/1/1990
            Console.WriteLine("----------Display a list of all the employee whose date of birth is after 1/1/1990-----------");
            var emp2 = employees.Where(e => e.DOB > new DateTime(1990, 1, 1)).Select(n => n);
            foreach (var i in emp2)
            {
                Console.WriteLine($"Employee Name : {i.FirstName}{i.LastName}, DOB : {i.DOB.ToShortDateString()}");
            }


            //3. Display a list of all the employee whose designation is Consultant and Associate
            Console.WriteLine("-----------Display a list of all the employee whose designation is Consultant and Associate-----------");
            var emp3 = employees.Where(e => e.Title == "Consultant" || e.Title == "Associate").Select(n => n);
            foreach (var i in emp3)
            {
                Console.WriteLine($"Employee Name : {i.FirstName}{i.LastName} , Title : {i.Title}");
            }

            //4. Display total number of employees
            Console.WriteLine("-------Display total number of employees------------");
            var emp4 = employees.Count();
            Console.WriteLine("Number of Employees : {0} ", emp4);

            //5. Display total number of employees belonging to “Chennai”
            Console.WriteLine("-------Display total number of employees belonging to “Chennai”------");
            var emp5 = employees.Where(e => e.City == "Chennai").Count();
            Console.WriteLine("Number of Employees : {0} ", emp5);

            //6. Display highest employee id from the list

            Console.WriteLine("-------Display highest employee id from the list-------");
            var emp6 = employees.Select(e => e.EmployeeID).Max();
            Console.WriteLine("highest employee id : {0} ", emp6);

            //7. Display total number of employee who have joined after 1/1/2015
            Console.WriteLine("-----------Display a list of all the employee who have joined after 1 / 1 / 2015------------");
            var emp7 = employees.Where(e => e.DOJ > new DateTime(2015, 1, 1)).Select(n => n);
            foreach (var i in emp7)
            {
                Console.WriteLine($"Employee Name : {i.FirstName}{i.LastName},DOJ : {i.DOJ.ToShortDateString()} ");
            }

            //8. Display total number of employee whose designation is not “Associate”
            Console.WriteLine("-----------Display total number of employee whose designation is not “Associate”-----------");
            var emp8 = employees.Where(e => e.Title != "Associate").Count();
            Console.WriteLine("total number of employees whose designation is not Associate : {0}", emp8);

            //9. Display total number of employee based on City
            Console.WriteLine("---------Display total number of employee based on City-----------");
            var emp9 = employees.GroupBy(e => e.City);
            foreach (var i in emp9)
            {
                Console.WriteLine($"{i.Key} : {i.Count()}");
            }

            //10. Display total number of employee based on city and title
            Console.WriteLine("---------Display total number of employee based on city and title-------------");
            var emp10 = employees.GroupBy(e => (e.City, e.Title));
            foreach (var i in emp10)
            {
                Console.WriteLine($"{i.Key.City} , {i.Key.Title}: {i.Count()}");
            }

            //11. Display total number of employee who is youngest in the list
            Console.WriteLine("---------Display total number of employee who is youngest in the list----------");
            var emp11 = employees.OrderBy(e => e.DOB).Last();
            Console.WriteLine("employee who is youngest in the list : ");
            Console.WriteLine($"Employee Id : {emp11.EmployeeID} , Employee Name : {emp11.FirstName}{emp11.LastName} , Title : {emp11.Title} , DOJ : {emp11.DOB.ToShortDateString()} , City : {emp11.City}");
            Console.Read();
        }
    }
}
