using System;

namespace zadanie8
{
    class Program
    {
//Napisz program, który sprawdzi, czy kandydat może ubiegać się o miejsce
//na studiach wg.Następujących kryteriów:
//Wynik z Matury z matematyki powyżej 70
//Wynik z fizyki powyżej 55
//Wynik z chemii powyżej 45
//Łączny wynik z 3 przedmiotów powyżej 180
//Albo
//Wynik z matematyki i jednego przedmiotu powyżej 150
//Dane testowe:
//Matematyka 80
//Fizyka 71
//Chemia 0
//Rezultat w terminalu :
//Kandydat dopuszczony do rekrutacji

        static void Main(string[] args)
        {
            Console.WriteLine("Witaj! \nPodaj swoje wyniki egzaminów, aby sprawdzić czy zostaniesz dopuszczony do rekrutacji na studia\n");

            int math = 80;
            int physics = 71;
            int chemistry = 0;

            Console.Write("wyniki to kolejno math {0}, physics {1}, chemistry {2}\n", math, physics, chemistry);

            if ((math >= 70 && physics >= 45 && physics >= 45) || (math + physics >= 150 || math + chemistry >= 150))
            {
                Console.WriteLine("\nGratulacje! Zostałeś dopuszczony do rekrutacji");
            }
            else
            {
                Console.WriteLine("\nWynik rekrutacji negatywny.");
            }
        }
    }
}
