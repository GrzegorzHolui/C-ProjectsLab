using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wielowątkowoś
{
    internal class MatrixGenerator
    {
        private Random random = new Random();

        public double[][] generateMatrix(int rows, int columns)
        {
            double[,] matrix = new double[rows, columns];

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    matrix[i, j] = random.NextDouble() * 10; // losowa liczba z zakresu od 0 do 10
                }
            }   

            return ToJaggedArray(matrix);
        }

        public int[][] generateMatrixInt(int rows, int columns)
        {
            int[,] matrix = new int[rows, columns];

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    matrix[i, j] = random.Next() * 1;
                }
            }

            return ToJaggedArray(matrix);
        }

        double[][] ToJaggedArray(double[,] array2D)
        {
            int rows = array2D.GetLength(0);
            int cols = array2D.GetLength(1);

            double[][] jaggedArray = new double[rows][];

            for (int i = 0; i < rows; i++)
            {
                jaggedArray[i] = new double[cols];
                for (int j = 0; j < cols; j++)
                {
                    jaggedArray[i][j] = array2D[i, j];
                }
            }

            return jaggedArray;
        }

        int[][] ToJaggedArray(int[,] array2D)
        {
            int rows = array2D.GetLength(0);
            int cols = array2D.GetLength(1);

            int[][] jaggedArray = new int[rows][];

            for (int i = 0; i < rows; i++)
            {
                jaggedArray[i] = new int[cols];
                for (int j = 0; j < cols; j++)
                {
                    jaggedArray[i][j] = array2D[i, j];
                }
            }

            return jaggedArray;
        }

    }
}
