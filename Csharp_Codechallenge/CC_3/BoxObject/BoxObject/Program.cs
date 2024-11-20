using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoxObject
{
   public class Box
    {
        public int Length { get; set; }
        public int Breadth { get; set; }

        public Box(int length, int breadth)
        {
            Length = length;
            Breadth = breadth;
        }

        public static Box operator +(Box B1, Box B2)
        {
            return new Box(B1.Length + B2.Length, B1.Breadth + B2.Breadth);
        }

        public override string ToString()
        {
            return $"Length: {Length}, Breadth: {Breadth}";
        }
    }

    class Test
    {
        static void Main()
        {
            Console.Write("Enter length of Box 1: ");
            int length1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter breadth of Box 1: ");
            int breadth1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter length of Box 2: ");
            int length2 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter breadth of Box 2: ");
            int breadth2 = Convert.ToInt32(Console.ReadLine());

            Box box1 = new Box(length1, breadth1);
            Box box2 = new Box(length2, breadth2);
            Box box3 = box1 + box2;

            Console.WriteLine("Box 1: " + box1);
            Console.WriteLine("Box 2: " + box2);
            Console.WriteLine("Box 3: " + box3);

            Console.Read();
        }
    }
}
