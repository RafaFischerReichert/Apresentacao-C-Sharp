using System;

class OverflowProgram
{
    static void Main()
    {
        // x recebe o valor máximo atribuível a um int
        int x = int.MaxValue;
        int y = 1;

        try
        {
            checked
            // checked permite checagem de Overflow ao custo de performance
            {
                int z = x + y;
                Console.WriteLine(z);
            }
        }
        catch (OverflowException)
        {
            Console.WriteLine("An overflow occurred.");
        }
    }
}
