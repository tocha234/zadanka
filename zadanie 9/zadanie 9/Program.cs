using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Podaj wartość a:");
        int a = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Podaj wartość b:");
        int b = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Podaj wartość c:");
        int c = Convert.ToInt32(Console.ReadLine());

        a = a + b;
        b = a - b;
        a = a - b;
        b = b + c;
        c = b - c;
        b = b - c;

        Console.WriteLine("Po zamianie miejscami:");
        Console.WriteLine("a: " + a);
        Console.WriteLine("b: " + b);
        Console.WriteLine("c: " + c);

        Console.ReadKey();
    }
}
