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



            Stopwatch stopwatch = new Stopwatch();
            Stopwatch stopwatch2 = new Stopwatch();

            wynik = new Matrix(dimension);
            Matrix m1 = new Matrix(dimension);
            Matrix m2 = new Matrix(dimension);

            Thread[] threads = new Thread[n];
            Random r = new Random();


            for (int i = 0; i < dimension; i++)
            {
                for (int j = 0; j < dimension; j++)
                {
                    m1.matrix[i, j] = r.Next(1, 5);
                    m2.matrix[i, j] = r.Next(1, 5);
                }
            }
            
            /*
            Console.WriteLine("To macierz pierwsza m1:\n");
            Console.WriteLine(m1.ToString());
            Console.WriteLine("To macierz pierwsza m2:\n");
            Console.WriteLine(m2.ToString());
            */
            
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
                int last = 0 ;
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

            stopwatch2.Start();
            int[,] konwencjonalne = m1 * m2;
            stopwatch2.Stop();

            TimeSpan czas = stopwatch.Elapsed;
            TimeSpan czas2 = stopwatch2.Elapsed;
            /*
            Console.WriteLine("To macierz wynikowa:\n");
            Console.WriteLine(wynik.ToString());
            */
            Console.WriteLine("\nCzas wymnożenia macierzy: " + czas.TotalMilliseconds + " milisekund\n");
            Console.WriteLine("\nCzas wymnożenia macierzy konwencjonalnie: " + czas2.TotalMilliseconds + " milisekund\n");
        }

        static void Oblicz(int row, Matrix m1, Matrix m2)
        {
            int[] result = m1.SolveRow(row, m2);

            for (int i = 0; i < wynik.matrix.GetLength(0); i++)
            {
                wynik.matrix[row, i] = result[i];
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

