using System.Diagnostics;

namespace LAB5
{
    internal class Program
    {
        public static volatile Matrix? wynik;
        static void Main(string[] args)
        {
            
            Console.WriteLine("Podaj liczbe watkow\n");
            int n = int.Parse(Console.ReadLine());

            Console.WriteLine("Podaj wymiar kwadratowej macierzy\n");
            int dimension = int.Parse(Console.ReadLine());
            
            /*
            int n = 500;
            int dimension = 1000;
            */

            Stopwatch stopwatch = new Stopwatch();
            Stopwatch stopwatch2 = new Stopwatch();

            wynik = new Matrix(dimension);
            Matrix m1 = new Matrix(dimension);
            Matrix m2 = new Matrix(dimension);



            Rozlosuj(dimension,m1, m2);

            /*
            Console.WriteLine("To macierz pierwsza m1:\n");
            Console.WriteLine(m1.ToString());
            Console.WriteLine("To macierz pierwsza m2:\n");
            Console.WriteLine(m2.ToString());
            */

            
           // for (int i = 0; i < 10; i++){


                RozdzielPrace(n, dimension, m1, m2, stopwatch);
                
                stopwatch2.Start();
                Matrix konwencjonalne = m1 * m2;
                stopwatch2.Stop();
                
                TimeSpan czas = stopwatch.Elapsed;
                TimeSpan czas2 = stopwatch2.Elapsed;

                /*
                Console.WriteLine("To macierz wynikowa:\n");
                Console.WriteLine(wynik.ToString());
                Console.WriteLine("To macierz wynikowa mnoznona konwencjonalnie:\n");
                Console.WriteLine(konwencjonalne.ToString());
                */


                Console.WriteLine("\nCzas wymnożenia macierzy: " + czas.TotalMilliseconds + " milisekund\n");
                
                Console.WriteLine("\nCzas wymnożenia macierzy konwencjonalnie: " + czas2.TotalMilliseconds + " milisekund\n");/
                
                stopwatch.Restart();
                stopwatch2.Restart();
           // }
        }

        static void Oblicz(int row, Matrix m1, Matrix m2)
        {
            int[] result = m1.SolveRow(row, m2);

            for (int i = 0; i < wynik.matrix.GetLength(0); i++)
            {
                wynik.matrix[row, i] = result[i];
            }

        }

        static void Rozlosuj(int dimension,Matrix m1, Matrix m2)
        {
            Random r = new Random();

            for (int i = 0; i < dimension; i++)
            {
                for (int j = 0; j < dimension; j++)
                {
                    m1.matrix[i, j] = r.Next(1, 15);
                    m2.matrix[i, j] = r.Next(1, 15);
                }
            }
        }
        static void RozdzielPrace(int n,int dimension,Matrix m1, Matrix m2, Stopwatch stopwatch)
        {
            Thread[] threads = new Thread[n];

            if (n >= dimension)
            {
                for (int i = 0; i < n; i++)
                {
                    int it = i;

                    if (i < dimension)
                    {
                        threads[it] = new Thread(() =>
                        {
                            Oblicz(it, m1, m2);

                        });
                    }
                }

                stopwatch.Start();
                for (int i = 0; i < dimension; i++)
                {
                    threads[i].Start();
                }
                for (int i = 0; i < dimension; i++)
                {
                    threads[i].Join();
                }
                stopwatch.Stop();

            }
            else if (n < dimension)
            {
                int last = 0;
                int started = 0;

                while (last != dimension)
                {
                    for (int i = 0; i < n; i++)
                    {
                        int it = i;

                        if (it + last < dimension)
                        {
                            threads[it] = new Thread(() =>
                            {
                                Oblicz(it + last, m1, m2);
                            });
                            started++;
                        }
                    }

                    stopwatch.Start();
                    for (int i = 0; i < started; i++)
                    {
                        threads[i].Start();
                    }
                    for (int i = 0; i < started; i++)
                    {

                        threads[i].Join();
                    }
                    last += started;
                    started = 0;
                    stopwatch.Stop();
                }
            }


        }
    }
}
    //volataile Macierz
    //uzycie stopera
    //w sumie max watkow tyle ile rdzeni procesora
    //zadanie ilosci watkow do programu
    //macierze losowane i moga byc kwadratowe
    //display macierzy i wynikowej
    //porownac czasy high level i low level

