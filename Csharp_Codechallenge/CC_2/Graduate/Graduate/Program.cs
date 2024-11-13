using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Graduate
{
    public abstract class Student
    {
        public string Name;
        public string StudentId;
        public double Grade;

        public Student(string name, string studentId, double grade)
        {
            Name = name;
            StudentId = studentId;
            Grade = grade;
        }

        public abstract string IsPassed();
    }

    public class Undergraduate : Student
    {
        public Undergraduate(string name, string studentId, double grade)
            : base(name, studentId, grade)
        {
        }

        public override string IsPassed()
        {
            if (Grade > 70.0)
                return "Passed";
            else
                return "Failed";
        }
    }

    public class Graduate : Student
    {
        public Graduate(string name, string studentId, double grade)
            : base(name, studentId, grade)
        {
        }

        public override string IsPassed()
        {
            if (Grade > 80.0)
                return "Passed";
            else
                return "Failed";
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Are you entering details for a Graduate or Undergraduate student?");
            Console.WriteLine("Type 'Undergraduate' or 'Graduate':");
            string studentType = Console.ReadLine().Trim();

            if (studentType.Equals("Undergraduate", StringComparison.OrdinalIgnoreCase))
            {
                Console.WriteLine("\nEnter Undergraduate Student Details:");

                Console.Write("Name: ");
                string undergradName = Console.ReadLine();

                Console.Write("Student ID: ");
                string undergradStudentId = Console.ReadLine();

                Console.Write("Grade: ");
                double undergradGrade = Convert.ToDouble(Console.ReadLine());

                Student undergrad = new Undergraduate(undergradName, undergradStudentId, undergradGrade);
                Console.WriteLine($"{undergrad.Name} {undergrad.IsPassed()} (Undergraduate)");
            }
            else if (studentType.Equals("Graduate", StringComparison.OrdinalIgnoreCase))
            {
                Console.WriteLine("\nEnter Graduate Student Details:");

                Console.Write("Name: ");
                string gradName = Console.ReadLine();

                Console.Write("Student ID: ");
                string gradStudentId = Console.ReadLine();

                Console.Write("Grade: ");
                double gradGrade = Convert.ToDouble(Console.ReadLine());

                Student grad = new Graduate(gradName, gradStudentId, gradGrade);
                Console.WriteLine($"{grad.Name} {grad.IsPassed()} (Graduate)");
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter either 'Undergraduate' or 'Graduate'.");
                
            }
            Console.Read();
        }
    }
}