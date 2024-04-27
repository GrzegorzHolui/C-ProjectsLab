using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wielowątkowoś
{
    internal class ParrarelMatrixMultiplication
    {
        public int[][] multiplyMatricesParallel(int[][] matrix1, int[][] matrix2, int amountOfThreads)
        {
            int row1 = matrix1.Length;
            int col1 = matrix1[0].Length;
            int row2 = matrix2.Length;
            int col2 = matrix2[0].Length;

            int[][] result = new int[row1][];

            ParallelOptions opt = new ParallelOptions()
            {
                MaxDegreeOfParallelism = amountOfThreads
            };

            var watch = System.Diagnostics.Stopwatch.StartNew();
            Parallel.For(0, row1, opt, i =>
            {
                result[i] = new int[col2];
                for (int j = 0; j < col2; j++)
                {
                    int sum = 0;
                    for (int k = 0; k < col1; k++)
                    {
                        sum += matrix1[i][k] * matrix2[k][j];
                    }
                    result[i][j] = sum;
                }
            });
            watch.Stop();

            Console.WriteLine($"threads in Parrel ended in {watch.ElapsedMilliseconds} ms.");
            /*Console.WriteLine($"{watch.ElapsedMilliseconds}");*/

            return result;
        }
    }
}
