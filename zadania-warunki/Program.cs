using System;

namespace zadania_warunki
{
    class Program
    {

//Napisz program w C#, który stworzy dwie zmienne int i sprawdzi czy są
//one równe czy nie.
//Dane testowe:
//a : 5
//b : 5
//Rezultat w terminalu : 5 i 5 są równe

        static void Main(string[] args)
        {
            var a = 5;
            var b = 5;

            if (a == b)
            {
                Console.WriteLine("Zmienne A i B są równe");
            }
            else
            {
                Console.WriteLine("Zmienne A i B nie są równe");
            }


        }
    }
}
