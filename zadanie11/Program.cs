using System;

namespace zadanie11
{
    class Program
    {
//Napisz program, który zmieni ocenę ucznia na jej opis wg podanej tabeli:
//Ocena Opis
//6 Celujący
//5 Bardzo dobry
//4 Dobry
//3 Dostateczny
//2 Dopuszczający
//1 Niedostateczny
//Dane testowe : 3
//Rezultat w terminalu :
//Dostateczny

        static void Main(string[] args)
        {
            Console.WriteLine("Podaj ocenę w skali od 1 do 6 aby program zmienił jej wartość na opis.");

            int ocena = 7;
            Console.Write("Podana ocena to: ");

            switch (ocena)
            {
                case 1:
                    Console.Write("Niedostateczny");
                    break;
                case 2:
                    Console.Write("Dopuszczający");
                    break;
                case 3:
                    Console.Write("Dostateczny");
                    break;
                case 4:
                    Console.Write("Dobry");
                    break;
                case 5:
                    Console.Write("Bardzo dobry");
                    break;
                case 6:
                    Console.Write("Celujący");
                    break;
                default:
                    Console.Write("Podana wartość jest błędna!");
                    break;
            }

        }
    }
}
