using System;

namespace zadanie9
{
    class Program
    {
//Napisz program, który odczyta temperaturę I zwróci nazwę jak w
//poniższych kryteriach
//Temp< 0 – cholernie piździ
//Temp 0 – 10 – zimno
//Temp 10 – 20 – chłodno
//Temp 20 – 30 – w sam raz
//Temp 30 – 40 – zaczyna być słabo, bo gorąco
//Temp >= 40 – a weź wyprowadzam się na Alaskę.
//Dane testowe : 41
//Rezultat w terminalu :
//a weź wyprowadzam się na Alaskę.
        static void Main(string[] args)
        {
            Console.WriteLine("Podaj temperaturę");
            float temperature = 41;
            Console.WriteLine("Temperatura wynosi: " + temperature);

            if (temperature < 0)
            {
                Console.WriteLine("\ncholernie piździ");
            }
            else if (0 > temperature && temperature < 10)
            {
                Console.WriteLine("\nzimno");
            }
            else if (10 > temperature && temperature < 20)
            {
                Console.WriteLine("\nchłodno");
            }
            else if (20 > temperature && temperature < 30)
            {
                Console.WriteLine("\nw sam raz");
            }
            else if (30 > temperature && temperature < 40)
            {
                Console.WriteLine("\nzaczyna być słabo, bo gorąco");
            }
            else
            {
                Console.WriteLine("\na weź wyprowadzam się na Alaskę");
            }

        }
    }
}
