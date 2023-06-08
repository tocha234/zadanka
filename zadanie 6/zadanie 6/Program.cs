using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Podaj długość pierwszego boku:");
        double bok1 = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Podaj długość drugiego boku:");
        double bok2 = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Podaj długość trzeciego boku:");
        double bok3 = Convert.ToDouble(Console.ReadLine());

        bool czyTrojkatRownoboczny = bok1 == bok2 && bok2 == bok3;

        if (czyTrojkatRownoboczny)
        {
            Console.WriteLine("Podane boki tworzą trójkąt równoboczny.");
        }
        else
        {
            Console.WriteLine("Podane boki nie tworzą trójkąta równobocznego.");
        }

        Console.ReadKey();
    }
}
