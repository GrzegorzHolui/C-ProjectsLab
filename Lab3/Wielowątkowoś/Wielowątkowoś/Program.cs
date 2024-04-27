using System;
using Wielowątkowoś;
internal class Program
{

    static void Main(string[] args)
    {

        /*---------------------zadanie 1 --------------------*/
        int[][] a = new int[][]
        {
                 new int[] { 1, 1, 1, 1 },
                 new int[] { 1, 1, 1, 1 },
                 new int[] { 2, 2, 2, 2 },
                 new int[] { 2, 2, 2, 2 }
        };


        int[][] c = new int[][]
        {
                 new int[] { 1, 1, 1, 1, 1, 1, 1, 1 },
                 new int[] { 1, 1, 1, 1, 1, 1, 1, 1 },
                 new int[] { 2, 2, 2, 2, 2, 2, 2, 2 },
                 new int[] { 2, 2, 2, 2, 2, 2, 2, 2 },
                 new int[] { 1, 1, 1, 1, 1, 1, 1, 1 },
                 new int[] { 1, 1, 1, 1, 1, 1, 1, 1 },
                 new int[] { 2, 2, 2, 2, 2, 2, 2, 2 },
                 new int[] { 2, 2, 2, 2, 2, 2, 2, 2 }
        };


        int[][] b = new int[][]
        {
                 new int[] { 1, 1, 1, 1, 1 },
                 new int[] { 1, 1, 1, 1, 1 },
                 new int[] { 2, 2, 2, 2, 2 },
                 new int[] { 2, 2, 2, 2, 2 },
                 new int[] { 2, 2, 2, 2 ,2 },
        };

        int height = 100;
        MatrixGenerator matrixGenerator = new MatrixGenerator();
        int amountOfThreads = 8;

        /*for (int i = 0; i < 20; i++)
        {*/
        /*Console.WriteLine(height);*/
        int[][] matrixA = matrixGenerator.generateMatrix(height, height);
        /*int[][] matrixA = a;*/

        /*printTheMatrix(matrixA);*/

        MatrixMultiplication multiplication = new MatrixMultiplication(matrixA, matrixA);
        int[][] result1 = multiplication.multiply(amountOfThreads);
/*        height += 100;
*/        /*}*/
        height = 100;
        Console.WriteLine();
        /*----------------Zadanie 2-------------------- -*/
        /*for (int i = 0; i < 20; i++)
        {*/
        /* int[][] matrixA = matrixGenerator.generateMatrix(height, height);*/

        ParrarelMatrixMultiplication parrarelMatrixMultiplication = new ParrarelMatrixMultiplication();
        int[][] result2 = parrarelMatrixMultiplication.multiplyMatricesParallel(matrixA, matrixA, amountOfThreads);
        height += 100;

        printTheMatrix(result1);
        Console.WriteLine();
        printTheMatrix(result2);

        /*}*/

    }

    static void printTheMatrix(int[][] matrix)
    {
        int rows = matrix.Length;
        int cols = matrix[0].Length;

        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                Console.Write(matrix[i][j] + "\t");
            }
            Console.WriteLine();
        }
    }

}
