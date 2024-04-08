using System.Drawing;
using System.Runtime.CompilerServices;

[assembly: InternalsVisibleTo("ParallerLAB5")]
[assembly: InternalsVisibleTo("GUI")]

namespace LAB5
{

    internal class Matrix
    {
        public int[,] matrix { set; get; }

        public Matrix(int dimension)
        {

            matrix = new int[dimension, dimension];

        }

        public override string ToString()
        {

            string output="";

            for(int i = 0; i < matrix.GetLength(0); i++)
            {
                output += "|";
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    output += matrix[i, j].ToString();
                    output += "|";
                }
                output += "\n";
            }
            return output;
        }

        public int[] SolveRow(int row, Matrix m2)
        {
            int[] result = new int[this.matrix.GetLength(0)]; //wynikowy wiersz

            int tmp = 0;

            for (int i = 0; i < this.matrix.GetLength(0); i++)
            {

                for (int j = 0; j < this.matrix.GetLength(0); j++)
                {

                    tmp += this.matrix[row, j] * m2.matrix[j, i];

                }
                result[i] = tmp;
                tmp = 0;
            }
            return result;
        }
        public static Matrix operator * (Matrix m1, Matrix m2)
        {

            Matrix result = new Matrix(m1.matrix.GetLength(0));

            for (int i = 0; i < m1.matrix.GetLength(0); i++)
            {
                for (int j = 0; j < m2.matrix.GetLength(1); j++)
                {
                    int tmp = 0;
                    for (int k = 0; k < m1.matrix.GetLength(1); k++)
                    {
                        tmp += m1.matrix[i, k] * m2.matrix[k, j];
                    }
                    result.matrix[i, j] = tmp;
                }
            }

            return result;
        }


    }
}
