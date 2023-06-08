using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Podaj liczbę naturalną:");
        int liczba = Convert.ToInt32(Console.ReadLine());

        int ostatniaCyfra = liczba % 10;

        Console.WriteLine("Ostatnia cyfra liczby {0} to: {1}", liczba, ostatniaCyfra);

        Console.ReadKey();
    }
}
