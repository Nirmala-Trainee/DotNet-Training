using System;
using System.Linq;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter an integers:");
        var input = Console.ReadLine();
        List<int> numbers = input.Split(' ').Select(int.Parse).ToList();


        var result = from number in numbers
                     let square = number * number
                     where square > 20
                     select new { Number = number, Square = square };

        Console.WriteLine("------Results------"); 

        foreach (var item in result)
        {
            Console.WriteLine($"Number: {item.Number}, Square: {item.Square}");
        }
        Console.ReadLine();
    }
}
