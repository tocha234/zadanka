using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Podaj współrzędną x punktu P:");
        double x = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Podaj współrzędną y punktu P:");
        double y = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Podaj współrzędną a środka koła:");
        double a = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Podaj współrzędną b środka koła:");
        double b = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Podaj promień koła:");
        double r = Convert.ToDouble(Console.ReadLine());

        double odleglosc = Math.Sqrt(Math.Pow(x - a, 2) + Math.Pow(y - b, 2));

        bool czyPunktWObrebieKola = odleglosc <= r;

        if (czyPunktWObrebieKola)
        {
            Console.WriteLine("Punkt P({0},{1}) leży w obrębie koła o środku O({2},{3}) i promieniu {4}.", x, y, a, b, r);
        }
        else
        {
            Console.WriteLine("Punkt P({0},{1}) nie leży w obrębie koła o środku O({2},{3}) i promieniu {4}.", x, y, a, b, r);
        }

        Console.ReadKey();
    }
}
