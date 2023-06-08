using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Podaj liczbę a:");
        int a = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Podaj liczbę b:");
        int b = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Podaj liczbę c:");
        int c = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Podaj liczbę d:");
        int d = Convert.ToInt32(Console.ReadLine());

        if (b == 0 || d == 0)
        {
            Console.WriteLine("Brak rozwiązania");
        }
        else
        {
            int x = a * d + b * c;
            int y = b * d;
            Console.WriteLine("Licznik (x): " + x);
            Console.WriteLine("Mianownik (y): " + y);
        }
        Console.ReadKey();
    }
}
