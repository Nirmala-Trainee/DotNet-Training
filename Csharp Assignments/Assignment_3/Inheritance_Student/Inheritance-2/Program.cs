using System;
using System.Collections.Generic;

namespace Inheritance_2
{
    class Student
    {
        protected int Roll_No;
        protected string Name;
        protected string Class_Name;
        protected int Semester;
        protected string Branch;
        protected int[] marks = new int[5];
        public Student(int roll_no, string name, string class_name, int sem, string branch)
        {
            Roll_No = roll_no;
            Name = name;
            Class_Name = class_name;
            Semester = sem;
            Branch = branch;
        }
        public void Get_Marks()
        {
            for (int i = 0; i < marks.Length; i++)
            {
                Console.WriteLine("Enter the subject {0} marks", i + 1);
                marks[i] = Convert.ToInt32(Console.ReadLine());
            }
        }
    }
    class Display_Marks : Student
    {
        public Display_Marks(int roll_no, string name, string class_name, int sem, string branch)
            : base(roll_no, name, class_name, sem, branch)
        {

        }
        public void Display_Result()
        {
            int sum = 0;
            float avg;
            for (int i = 0; i < marks.Length; i++)
            {
                sum = sum = marks[i];
            }
            avg = sum / marks.Length;
            for (int j = 0; j < marks.Length; j++)
            {
                if (marks[j] < 35)
                {
                    Console.WriteLine("Failed in subject {0}", j + 1);
                }
            }
            if (avg > 50)
            {
                Console.WriteLine("Student Passed and Average is {0}", avg);
            }
            else
            {
                Console.WriteLine("Student Failed and Average is {0}", avg);
            }
        }
        public void Display_Data()
        {
            Console.WriteLine("Student Roll no:{0}", Roll_No);
            Console.WriteLine("Student Name:{0}", Name);
            Console.WriteLine("Class:{0}", Class_Name);
            Console.WriteLine("Semester:{0}", Semester);
            Console.WriteLine("Branch:{0}", Branch);

        }
    }
    class Student1
    {
        public static void Main()
        {
            Console.WriteLine("Enter the student roll");
            int roll_no = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the student name");
            string name = Console.ReadLine();
            Console.WriteLine("Enter the student class");
            string class_name = Console.ReadLine();
            Console.WriteLine("Enter the semester");
            int sem = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the student branch");
            string branch = Console.ReadLine();
            Display_Marks d = new Display_Marks(roll_no, name, class_name, sem, branch);
            d.Get_Marks();
            d.Display_Result();
            d.Display_Data();
            Console.Read();
        }
    }
}
