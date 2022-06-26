using System;

namespace zadanie12
{
    class Program
    {
//Napisz program, który pobierze numer dnia tygodnia i wyświetli jego
//nazwę
//Dane testowe : 4
//Rezultat w terminalu : Czwartek

        enum Week
        {
            poniedziałek = 1,
            wtorek,
            środa,
            czwartek,
            piątek,
            sobota,
            niedziela
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Podaj numer dnia tygodnia");
            Console.WriteLine("Wskazałeś: 4");
            var day = (Week)4;
            Console.Write("Jest to: ");
            Console.WriteLine(day);
        }

    }
}
