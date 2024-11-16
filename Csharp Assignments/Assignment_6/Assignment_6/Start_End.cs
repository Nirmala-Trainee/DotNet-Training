using System;
using System.Collections.Generic;
using System.Linq;

class Start_End
{
    static void Main()
    {
        Console.WriteLine("Enter the Names:");
        var input = Console.ReadLine();
        List<string> words = input.Split(' ').ToList();

        var RequiredName = words.Where(word => word.StartsWith("a") && word.EndsWith("m")).ToList();

        Console.WriteLine("Words starting with 'a' and ending with 'm':");
        foreach (var word in RequiredName)
        {
            Console.WriteLine(word);
        }
        Console.ReadLine();
    }
}
