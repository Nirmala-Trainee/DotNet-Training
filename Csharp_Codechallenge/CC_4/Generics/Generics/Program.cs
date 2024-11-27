using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
    public class Program
    {
        public static void Main(string[] args)
        {
            List<Employee> empList = new List<Employee>
        {
           new Employee(1001, "Malcolm", "Daruwalla", "Manager", new DateTime(1984, 11, 16), new DateTime(2011, 06, 08), "Mumbai"),
           new Employee(1002, "Asdin", "Dhalla", "AsstManager", new DateTime(1994, 08, 20), new DateTime(2012, 07, 07), "Mumbai"),
           new Employee(1003, "Madhavi", "Oza", "Consultant", new DateTime(1987, 11, 14), new DateTime(2015, 04, 12), "Pune"),
           new Employee(1004, "Saba", "Shaikh", "SE", new DateTime(1990, 06, 03), new DateTime(2016, 02, 02), "Pune"),
           new Employee(1005, "Nazia", "Shaikh", "SE", new DateTime(1991, 03, 08), new DateTime(2016, 02, 02), "Mumbai"),
           new Employee(1006, "Amit", "Pathak", "Consultant", new DateTime(1989, 11, 07), new DateTime(2014, 08, 08), "Chennai"),
           new Employee(1007, "Vijay", "Natrajan", "Consultant", new DateTime(1989, 12, 02), new DateTime(2015, 06, 01), "Mumbai"),
           new Employee(1008, "Rahul", "Dubey", "Associate", new DateTime(1993, 11, 11), new DateTime(2014, 11, 06), "Chennai"),
           new Employee(1009, "Suresh", "Mistry", "Associate", new DateTime(1992, 08, 12), new DateTime(2014, 12, 03), "Chennai"),
           new Employee(1010, "Sumit", "Shah", "Manager", new DateTime(1991, 04, 12), new DateTime(2016, 01, 02), "Pune")
       };
 
            var allEmployees = from emp in empList
                               select emp;
            Console.WriteLine("All Employee Details:");
            foreach (var employee in allEmployees)
            {
                Console.WriteLine($"EmployeeID: {employee.EmployeeID}, Name: {employee.FirstName} {employee.LastName}, Title: {employee.Title}, DOB: {employee.DOB.ToShortDateString()}, DOJ: {employee.DOJ.ToShortDateString()}, City: {employee.City}");
            }

            var nonMumbaiEmployees = from emp in empList
                                     where emp.City != "Mumbai"
                                     select emp;
            Console.WriteLine("\nEmployees Not in Mumbai:");
            foreach (var employee in nonMumbaiEmployees)
            {
                Console.WriteLine($"EmployeeID: {employee.EmployeeID}, Name: {employee.FirstName} {employee.LastName}, Title: {employee.Title}, DOB: {employee.DOB.ToShortDateString()}, DOJ: {employee.DOJ.ToShortDateString()}, City: {employee.City}");
            }

            var asstManagerEmployees = from emp in empList
                                       where emp.Title == "AsstManager"
                                       select emp;
            Console.WriteLine("\nEmployees with Title 'AsstManager':");
            foreach (var employee in asstManagerEmployees)
            {
                Console.WriteLine($"EmployeeID: {employee.EmployeeID}, Name: {employee.FirstName} {employee.LastName}, Title: {employee.Title}, DOB: {employee.DOB.ToShortDateString()}, DOJ: {employee.DOJ.ToShortDateString()}, City: {employee.City}");
            }

            var employeesWithLastNameS = from emp in empList
                                         where emp.LastName.StartsWith("S")
                                         select emp;
            Console.WriteLine("\nEmployees with Last Name starting with 'S':");
            foreach (var employee in employeesWithLastNameS)
            {
                Console.WriteLine($"EmployeeID: {employee.EmployeeID}, Name: {employee.FirstName} {employee.LastName}, Title: {employee.Title}, DOB: {employee.DOB.ToShortDateString()}, DOJ: {employee.DOJ.ToShortDateString()}, City: {employee.City}");
            }
            Console.Read();
        }
    }
}
