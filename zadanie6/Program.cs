using System;

namespace zadanie6
{
    class Program
    {
//Napisz program w C#, który pobierze wzrost użytkownika i przypisze mu
//wymyśloną kategorię wzrostu.
//Dane testowe : 140
//Rezultat w terminalu : Jesteś krasnoludem

        static void Main(string[] args)
        {
            Console.WriteLine("Podaj swój wzrost w [cm]");
            var wzrost = 140;
            Console.WriteLine(wzrost);

            if (wzrost >= 120 && wzrost < 150)
            {
                Console.WriteLine("Jesteś krasnoludem");
            }
            else if (wzrost > 180 && wzrost < 220)
            {
                Console.WriteLine("Jesteś wysoki");
            }
            else
            {
                Console.WriteLine("podano błędną wartość");
            }
        }
    }
}
