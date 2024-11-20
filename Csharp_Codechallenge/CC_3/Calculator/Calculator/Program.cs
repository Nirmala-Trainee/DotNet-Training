using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    public delegate int Calculator(int x, int y);

    class Program
    {
        static int Addition(int x, int y) => x + y;
        static int Subtraction(int x, int y) => x - y;
        static int Multiplication(int x, int y) => x * y;

        static void Calculate(Calculator calc, string operation)
        {
            Console.Write($"Enter first number for {operation}: ");
            int x = Convert.ToInt32(Console.ReadLine());
            Console.Write($"Enter second number for {operation}: ");
            int y = Convert.ToInt32(Console.ReadLine());
            int result = calc(x, y);
            Console.WriteLine($"{operation} result: {result}");
        }

        static void Main()
        {
            Console.WriteLine("Calculator Operations:");
            Calculator calcAdd = Addition;
            Calculate(calcAdd, "Addition");

            Calculator calcSubtract = Subtraction;
            Calculate(calcSubtract, "Subtraction");

            Calculator calcMultiply = Multiplication;
            Calculate(calcMultiply, "Multiplication");

            Console.Read();
        }
    }
}
