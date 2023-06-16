using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Podaj kwotę początkową na koncie:");
        decimal kwotaPoczatkowa = Convert.ToDecimal(Console.ReadLine());

        Console.WriteLine("Podaj oprocentowanie konta w skali roku:");
        decimal oprocentowanie = Convert.ToDecimal(Console.ReadLine());

        Console.WriteLine("Podaj liczbę miesięcy oszczędzania:");
        int liczbaMiesiecy = Convert.ToInt32(Console.ReadLine());

        decimal kwotaKoncowa = ObliczKwoteKoncowa(kwotaPoczatkowa, oprocentowanie, liczbaMiesiecy);

        Console.WriteLine("Kwota końcowa: " + kwotaKoncowa);
    }

    static decimal ObliczKwoteKoncowa(decimal kwotaPoczatkowa, decimal oprocentowanie, int liczbaMiesiecy)
    {
        decimal oprocentowanieMiesieczne = oprocentowanie / 12 / 100;
        decimal kwotaKoncowa = kwotaPoczatkowa * (decimal)Math.Pow(1 + (double)oprocentowanieMiesieczne, liczbaMiesiecy);
        kwotaKoncowa *= (decimal)Math.Pow(1 - 0.19, liczbaMiesiecy); // uwzględnienie podatku Belki (19%)

        return kwotaKoncowa;
    }
}
