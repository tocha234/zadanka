using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Podaj liczbę n: ");
        int n = int.Parse(Console.ReadLine());

        Random random = new Random();
        int count = 0;

        Console.Write("Wylosowane liczby: ");

        while (count < n)
        {
            int number = random.Next(-8, 9);

            if (number % 2 == 0)
            {
                Console.Write(number);

                count++;
                if (count < n)
                {
                    Console.Write(", ");
                }
            }
            else
            {
                count++;
            }
        }

        Console.WriteLine();
        Console.WriteLine("Liczba wykonanych losowań: " + count);
    }
}
