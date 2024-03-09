using System.Drawing;

namespace Konsolowa
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            Result wynik;

            Console.WriteLine("Podaj n\n");
            
            
            int n;
            if (!int.TryParse(Console.ReadLine(), out n))
            {

                Console.WriteLine("Podano zły parametr n");
                return;
            }
            if (n < 0 || n > 100000)
            {

                Console.WriteLine("Podano zły parametr n");
                return;
            }
            Console.WriteLine("Podaj seed\n");
            int seed;
            if (!int.TryParse(Console.ReadLine(), out seed))
            {

                Console.WriteLine("Podano zły parametr seed");
                return;
            }

            if (seed < 0 || seed > 100000)
            {

                Console.WriteLine("Podano zły parametr seed");
                return;
            }
            Console.WriteLine("Podaj pojemnosc\n");
            int capacity;
            if (!int.TryParse(Console.ReadLine(), out capacity))
            {

                Console.WriteLine("Podano zły parametr capacity");
                return;
            }
            if (capacity < 0 || capacity > 100000)
            {

                Console.WriteLine("Podano zły parametr capacity");
                return;
            }

            Problem plecak = new Problem(n, seed);
            wynik=plecak.Solve(capacity,true);
            Console.WriteLine(wynik.ToString());


        }
    }
}
