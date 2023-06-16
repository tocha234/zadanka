using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Wybierz liczbę z przedziału 1-20.");
        Console.WriteLine("Naciśnij dowolny klawisz, gdy będziesz gotowy.");
        Console.ReadKey();

        int dolnyPrzedzial = 1;
        int gornyPrzedzial = 20;
        int propozycja;
        char odpowiedz;

        do
        {
            propozycja = (dolnyPrzedzial + gornyPrzedzial) / 2;
            Console.WriteLine("Czy Twoja liczba to " + propozycja + "?");
            Console.WriteLine("Odpowiedz ujemną, jeśli propozycja jest za duża.");
            Console.WriteLine("Odpowiedz dodatnią, jeśli propozycja jest za mała.");
            Console.WriteLine("Odpowiedz zerem, jeśli zgadłem.");

            odpowiedz = Console.ReadKey().KeyChar;
            Console.WriteLine();

            if (odpowiedz < '0')
            {
                gornyPrzedzial = propozycja - 1;
            }
            else if (odpowiedz > '0')
            {
                dolnyPrzedzial = propozycja + 1;
            }

        } while (odpowiedz != '0');

        Console.WriteLine("Odgadłem! Twoja liczba to " + propozycja + ".");
    }
}
