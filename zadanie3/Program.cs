using System;

namespace zadanie3
{
    class Program
    {

//Napisz program w C#, który sprawdzi czy podana przez użytkownika liczba
//jest dodatnia czy ujemna.
//Dane testowe : 14
//Rezultat w terminalu : 14 jest liczbą dodatnią
        
        static void Main(string[] args)
        {
            var liczba = 14;

            if (liczba > 0)
            {
                Console.WriteLine("podana liczba jest dodatnia");
            }
        }
    }
}
