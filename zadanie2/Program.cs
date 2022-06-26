using System;

namespace zadanie2
{
    class Program
    {

//Napisz program w C#, który sprawdzi czy podana przez użytkownika liczba
//jest parzysta czy nieparzysta.
//Dane testowe : 15
//Rezultat w terminalu :
//15 jest liczbą nieparzystą

        static void Main(string[] args)
        {
            var a = 15;

            if (a % 2 == 0)
            {
                Console.WriteLine("Zmienna a jest parzysta");
            }
            else 
            {
                Console.WriteLine("Zmienna a = 15 jest nieparzysta");
            }
            

        }
    }
}
