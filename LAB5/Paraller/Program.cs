using System.Diagnostics;
using LAB5;



namespace ParallerLAB5

{
    internal class Program { 
   

        public static volatile Matrix? wynik;

        static void Main(string[] args)
        {
            Console.WriteLine("Podaj liczbe watkow\n");
            int n = int.Parse(Console.ReadLine());

            Console.WriteLine("Podaj wymiar kwadratowej macierzy\n");
            int dimension = int.Parse(Console.ReadLine());

            Stopwatch stopwatch = new Stopwatch();

            wynik = new Matrix(dimension);
            Matrix m1 = new Matrix(dimension);
            Matrix m2 = new Matrix(dimension);

            Random r = new Random();

            ParallelOptions opt = new ParallelOptions()
            {
                MaxDegreeOfParallelism =n
            };

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
                stopwatch.Start();
                Parallel.For(0, dimension, i =>
                {
                    Oblicz(i, m1, m2);
                });
                stopwatch.Stop();
            }
            else if (n < dimension)
            {
                int last = 0;
                int started = 0;

                stopwatch.Start();
                while (last < dimension)
                {
                    Parallel.For(last, Math.Min(n+last,dimension), i =>
                    {
                        Oblicz(i, m1, m2);
                        started++;
                    });
                    last += started;
                    started= 0;
                }
                stopwatch.Stop();
            }

            TimeSpan czas = stopwatch.Elapsed;

            /*
            Console.WriteLine("To macierz wynikowa:\n");
            Console.WriteLine(wynik.ToString());
            */
            Console.WriteLine("\nCzas wymnożenia macierzy: " + czas.TotalMilliseconds + " milisekund\n");
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