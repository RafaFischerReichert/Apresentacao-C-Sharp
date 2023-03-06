using System;

namespace Example
{
    enum DaysOfWeek
    {
        Domingo,
        Segunda,
        Terca,
        Quarta,
        Quinta,
        Sexta,
        Sabado
    }

    class NamespaceProgram
    {
        static void Main()
        {
            Console.WriteLine("Dias da semana:");

            foreach (string day in Enum.GetNames(typeof(DaysOfWeek)))
            {
                Console.WriteLine(day);
            }

            Console.WriteLine();

            Console.WriteLine("Valores dos dias da semana:");

            foreach (int value in Enum.GetValues(typeof(DaysOfWeek)))
            {
                Console.WriteLine(value);
            }
        }
    }
}
