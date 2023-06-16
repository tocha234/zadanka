using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Podaj podstawę potęgi:");
        int podstawa = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Podaj wykładnik potęgi:");
        int wykladnik = Convert.ToInt32(Console.ReadLine());

        int wynik = Potegowanie(podstawa, wykladnik);

        Console.WriteLine("Wynik: " + wynik);
    }

    static int Potegowanie(int podstawa, int wykladnik)
    {
        int wynik = 1;

        for (int i = 0; i < wykladnik; i++)
        {
            wynik *= podstawa;
        }

        return wynik;
    }
}
