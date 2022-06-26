using System;
using System.Linq;

namespace Zadanie7
{
    class Program
    {
//Napisz program w C#, który pobierze 3 liczby od użytkownika i sprawdzi,
//która jest największa
//Dane testowe:
//25
//63
//79
//Rezultat w terminalu : 79 jest największa z podanych

        static void Main(string[] args)
        {
            Console.WriteLine("Podaj trzy liczby, ustalę któa z nich jest największa.");

            int[] tablica = new int[] { 25, 79, 63 };

            var max = tablica.Max();
            Console.WriteLine("Największa wartość ze zbioru to: " + max);
        }
    }
}
