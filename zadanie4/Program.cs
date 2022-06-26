using System;

namespace zadanie4
{
    class Program
    {
//Napisz program w C#, który sprawdzi czy podany przez użytkownika rok
//jest rokiem przestępnym.
//Dane testowe : 2016
//Rezultat w terminalu :
//2016 jest rokiem przestępnym


        static void Main(string[] args)
        {
            var rok = 2016;

            if ((rok % 4 == 0 && rok % 100 != 0) 
                || ( rok % 400 == 0))
            {
                Console.WriteLine($"Rok {rok} jest rokiem przestępnym");
            }
            else 
            {
                Console.WriteLine($"Rok {rok} nie jest rokiem przestępnym");
            }
        }
    }
}
