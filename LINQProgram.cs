using System;
using System.Collections.Generic;
using System.Linq;

class LINQProgram
{
    static void Main()
    {
        List<int> numbers = new List<int> { 1, 2, 3, 4, 5 };

        // essa é a query LINQ
        var evenNumbers = from n in numbers where n % 2 == 0 select n;

        Console.WriteLine("Pares:");

        foreach (int n in evenNumbers)
        {
            Console.WriteLine(n);
        }

        // sum é um método provido pela LINQ
        var sum = numbers.Sum();

        Console.WriteLine("Soma dos numeros: " + sum);
    }
}
