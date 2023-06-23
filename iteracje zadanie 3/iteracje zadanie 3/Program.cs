using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Podaj wysokość trójkąta: ");
        int height = int.Parse(Console.ReadLine());

        int width = 2 * height - 1;

        for (int row = 1; row <= height; row++)
        {
            int numSymbols = 2 * row - 1;
            int numSpaces = (width - numSymbols) / 2;

            for (int space = 0; space < numSpaces; space++)
            {
                Console.Write(" ");
            }

            for (int symbol = 0; symbol < numSymbols; symbol++)
            {
                Console.Write("+");
            }

            Console.WriteLine();
        }
    }
}
