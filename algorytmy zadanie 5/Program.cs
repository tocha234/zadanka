using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Podaj wartość x:");
        double x = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Podaj liczbę wyrazów n:");
        int n = Convert.ToInt32(Console.ReadLine());

        double wynik = ObliczWyrazenie(x, n);

        Console.WriteLine("Wartość e^x: " + wynik);
    }

    static double ObliczWyrazenie(double x, int n)
    {
        double wynik = 0;
        double potega = 1;
        double silnia = 1;

        for (int i = 0; i <= n; i++)
        {
            wynik += potega / silnia;
            potega *= x;
            silnia *= i + 1;
        }

        return wynik;
    }
}
