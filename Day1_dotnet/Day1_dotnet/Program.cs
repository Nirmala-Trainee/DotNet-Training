using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day1_dotnet
{
    class Program
    {
        static void Main(String[] args);
        public static int Calculator(int a, int b, out int sum, out int product)
        {
            sum = a + b;  //addition
            product = a * b;  //multiplication
            return a - b; // difference
        }
    }

}
