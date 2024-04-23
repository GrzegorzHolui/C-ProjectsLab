using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Wielowątkowoś
{
    internal class ParallelMatrix
    {

        public void divideMatrix(int amountOfThreads, Matrix matrixLeft)
        {
            List<Matrix> result = new List<Matrix>();
            int lengthIteration = matrixLeft.matrix.Length;
            int startRow = 0;
            int endRow = amountOfThreads - 1;
            while (lengthIteration > 0)
            {
                double[][] matrix_d;
                if (endRow > matrixLeft.matrix.Length - 1)
                {
                    matrix_d = getMatrixFragment(matrixLeft.matrix, startRow, matrixLeft.matrix.Length - 1, 0, matrixLeft.matrix.Length - 1);
                }
                else
                {
                    matrix_d = getMatrixFragment(matrixLeft.matrix, startRow, endRow, 0, matrixLeft.matrix.Length - 1);
                }
                Matrix matrix = new Matrix(matrix_d);
                result.Add(matrix);
                lengthIteration -= amountOfThreads;
                int temp = endRow;
                startRow = temp + 1;
                endRow += amountOfThreads;
            }



            Console.WriteLine(result.Count);
            /*foreach (var item in result)
            {
                item.printTheMatrix();
            }*/
        }

        public double[][] getMatrixFragment(double[][] matrix, int startRow, int endRow, int startColumn, int endColumn)
        {
            // Sprawdzamy czy indeksy są w granicach macierzy
            if (startRow < 0 || startRow >= matrix.Length || endRow < 0 || endRow >= matrix.Length ||
                startColumn < 0 || startColumn >= matrix[0].Length || endColumn < 0 || endColumn >= matrix[0].Length)
            {
                throw new ArgumentException("Indeksy poza granicami macierzy.");
            }

            // Tworzymy nową macierz dla fragmentu
            double[][] fragment = new double[endRow - startRow + 1][];

            // Kopiujemy fragment macierzy
            for (int i = startRow; i <= endRow; i++)
            {
                // Tworzymy nową tablicę dla wiersza
                fragment[i - startRow] = new double[endColumn - startColumn + 1];

                for (int j = startColumn; j <= endColumn; j++)
                {
                    // Kopiujemy wartość z oryginalnej macierzy do fragmentu
                    fragment[i - startRow][j - startColumn] = matrix[i][j];
                }
            }

            return fragment;
        }

    }
}
