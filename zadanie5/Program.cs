using System;

namespace zadanie5
{
    class Program
    {
//Napisz program w C#, który sprawdzi czy podany przez użytkownika wiek
//uprawnia go do ubiegania się o stanowisko posła, premiera, sentarora,
//prezydenta.
//Dane testowe : 21
//Rezultat w terminalu : Możesz zostać posłem

        static void Main(string[] args)
        {
            var wiek = 21;

            if (wiek >= 21 && wiek < 24)
            {
                Console.WriteLine("Możesz zostać posłem i premierem");
            }
            else if (wiek >= 24 && wiek < 35)
            {
                Console.WriteLine("Możesz zostać posłem, premierem i senatorem");
            }
            else if (wiek >= 35)
            {
                Console.WriteLine("Możesz zostać posłem, senatorem i prezydentem");
            }
        }
    }
}
