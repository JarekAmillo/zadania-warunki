using System;

namespace zadanie13
{
    class Program
    {
//Napisz program, który będzie posiadał proste menu(wg.Wzoru poniżej) I
//będzie prostym kalkulatorem
//Podaj pierwszą liczbę:
//…
//Podaj drugą liczbę:
//…
//Podaj numer operacji do wykonania:
//1. Dodawanie
//2. Odejmowanie
//3. Mnożenie
//4. Dzielenie
//…
//Twój wynik to:

        static void Main(string[] args)
        {
            Console.WriteLine("Witaj w kalkulatorze!");
            Console.WriteLine("\nPodaj pierwszą liczbę");
            int a = Int32.Parse(Console.ReadLine());

            Console.WriteLine("\nPodaj drugą liczbę");
            int b = Int32.Parse(Console.ReadLine());
            //var b = 6;
            int wynik = 0;

            Console.WriteLine("\nJaką chcesz operację wykonać? Wskaż liczbę która odpowiada operacji");
            Console.Write("1 : dodawanie\n2 : odejmowanie\n3 : mnożenie\n4 : dzielenie\n");
            Console.WriteLine("");
            int operacja;
            //Console.WriteLine("wybrano operację " + (Console.ReadLine()));
            operacja = Int32.Parse(Console.ReadLine());

            switch (operacja)
            {
                case 1 :
                    wynik = a + b;
                    Console.WriteLine($"\nsuma liczb {a} i {b} to: " + wynik);
                    break;
                case 2:
                    wynik = a - b;
                    Console.WriteLine($"\nróżnica liczb {a} i {b} to: " + wynik);
                    break;
                //case 3:
                //    a* b
                //        break;
                //case 4:
                //    if (b == 0)
                //    {
                //        Console.WriteLine("Błąd! Nie można dzielić przez zero!");
                //        break;
                //    }
                //    a / b
                //    break;
                default:
                    Console.WriteLine("Podano niewłaściwą operację.");
                    break;
            }

        }
    }
}
