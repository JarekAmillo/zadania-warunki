using System;
using System.Linq;

namespace zadanie10
{
    class Program
    {
        //Napisz program, który sprawdzi, czy z 3 podanych długości można
        //stworzyć trójkąt
        //Dane testowe : 40 55 65
        //Rezultat w terminalu :
        //Można zbudować trójkąt

        static void Main(string[] args)
        {
            Console.WriteLine("Podaj długości boków, aby sprawdzić czy można z niego zbudować trókąt");

            int[] tablica = new int[3] { 65, 40, 55 };
            Console.Write("Podano wartości: ");
            foreach (int i in tablica)
            {
                Console.Write(i + ", ");
            }

            Console.Write("\n\nDokonano posortowana tablicy, boki trójkąta mają odpowiednio: ");
            Array.Sort(tablica);
            foreach (int i in tablica)
            {
                Console.Write(i + ", ");
            }


            if (tablica[0]+tablica[1] > tablica[2])
            {
                Console.WriteLine("\n\nGratulacje, możesz zbudować trójkąt!");
            }
            else
            {
                Console.WriteLine("\nNie możesz zbudować trójkąta!");
            }
        }
    }
}
