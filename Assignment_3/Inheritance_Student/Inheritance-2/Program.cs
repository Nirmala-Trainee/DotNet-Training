using System;
using System.Collections.Generic;

namespace Inheritance_2
{
    class Student
    {
        public int RollNo { get; set; }
        public string Name { get; set; }
        public string StudentClass { get; set; }
        public string Semester { get; set; }
        public string Branch { get; set; }
        private int[] Marks { get; set; }

        public Student(int rollNo, string name, string studentClass, string semester, string branch)
        {
            RollNo = rollNo;
            Name = name;
            StudentClass = studentClass;
            Semester = semester;
            Branch = branch;
            Marks = new int[0];
        }
        public void GetMarks()
        {
            Console.Write("Enter number of subjects: ");
            int numSubjects = int.Parse(Console.ReadLine());
            Marks = new int[numSubjects];

            for (int i = 0; i < numSubjects; i++)
            {
                Console.Write($"Enter marks for subject {i + 1}: ");
                Marks[i] = int.Parse(Console.ReadLine());
            }
        }

        public void DisplayResult()
        {
            if (Marks.Length == 0)
            {
                Console.WriteLine("Marks have not been entered yet.");
                return;
            }

            int totalMarks = 0;
            bool failed = false;

            foreach (int mark in Marks)
            {
                totalMarks += mark;
                if (mark < 35)
                {
                    failed = true;
                }
            }

            double average = totalMarks / (double)Marks.Length;

            if (!failed && average < 50)
            {
                failed = true;
            }

            if (failed)
            {
                Console.WriteLine("Result: Failed");
            }
            else if (average >= 50)
            {
                Console.WriteLine("Result: Passed");
            }
            else
            {
                Console.WriteLine("Result: Failed");
            }
        }

        public void DisplayData()
        {
            Console.WriteLine("Student Details:");
            Console.WriteLine($"Roll No: {RollNo}");
            Console.WriteLine($"Name: {Name}");
            Console.WriteLine($"Class: {StudentClass}");
            Console.WriteLine($"Semester: {Semester}");
            Console.WriteLine($"Branch: {Branch}");
            Console.WriteLine("Marks: " + string.Join(", ", Marks));
        }
    }

    class Program
    {
        static void Main()
        {
            Student student = new Student(10, "Amith", "8th", "1th", "Maths");
            student.GetMarks();
            student.DisplayResult();
            student.DisplayData();
            Console.ReadLine();
        }
    }
}