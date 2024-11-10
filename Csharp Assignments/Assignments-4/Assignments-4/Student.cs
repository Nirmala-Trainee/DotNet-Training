using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_4
{
    public interface IStudent
    {
        int Student_Id { get; set; }
        string Name { get; set; }
        void Show_details();
    }
    class Day_Scholar : IStudent
    {
        public int Student_Id { get; set; }
        public string Name { get; set; }
        public void Show_details()
        {
            Console.WriteLine("Student Id: {0}, Student Name:{1}", Student_Id, Name);
        }

    }
    class Resident : IStudent
    {
        public int Student_Id { get; set; }
        public string Name { get; set; }
        public void Show_details()
        {
            Console.WriteLine("Student Id: {0}, Student Name:{1}", Student_Id, Name);
        }

    }

    class Interface
    {
        static void Main()
        {
            Console.WriteLine("------Entering day scholar student details----");
            Console.WriteLine("Enter student Id");
            int sid1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Student name");
            String sname1 = Console.ReadLine();
            Console.WriteLine("------Entering Resident student details----");
            Console.WriteLine("Enter student Id");
            int sid2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Student name");
            String sname2 = Console.ReadLine();
            IStudent d = new Day_Scholar();
            d.Student_Id = sid1;
            d.Name = sname1;
            Console.WriteLine("----Displaying Day Scholar Students details----");
            d.Show_details();

            IStudent r = new Resident();
            r.Student_Id = sid2;
            r.Name = sname2;
            Console.WriteLine("----Displaying Resident Students details----");
            r.Show_details();
            Console.Read();
        }
    }

}
