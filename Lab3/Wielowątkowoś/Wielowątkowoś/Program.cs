using Wielowątkowoś;
internal class Program
{



    static void Main(string[] args)
    {

        /*---------------------zadanie 1 --------------------*/
        double[][] a = new double[][]
        {
                 new double[] { 1.0, 1.0, 1.0, 1.0 },
                 new double[] { 1.0, 1.0, 1.0, 1.0 },
                 new double[] { 2.0, 2.0, 2.0, 2.0 },
                 new double[] { 2.0, 2.0, 2.0, 2.0 }
        };


        double[][] b = new double[][]
        {
                 new double[] { 1.0, 1.0, 1.0, 1.0, 1.0 },
                 new double[] { 1.0, 1.0, 1.0, 1.0, 1.0 },
                 new double[] { 2.0, 2.0, 2.0, 2.0, 2.0 },
                 new double[] { 2.0, 2.0, 2.0, 2.0, 2.0 },
                 new double[] { 2.0, 2.0, 2.0, 2.0 ,2.0 },
        };

        MatrixGenerator matrixGenerator = new MatrixGenerator();
        double[][] matrixA = matrixGenerator.generateMatrix(1000, 1000);
       /* double[][] matrixB = matrixGenerator.generateMatrix(1000, 1000);*/


        /*MatrixMultiplication multiplication = new MatrixMultiplication(matrixA, matrixB);
        int amountOfThreads = 8;
        multiplication.multiply(amountOfThreads);*/

        /*---------------- Zadanie 2 ---------------------*/
        ParallelMatrix parallel = new ParallelMatrix();
        Matrix matrix = new Matrix(matrixA);
        parallel.divideMatrix(3, matrix);
        /*parallel.getMatrixFragment(matrix.matrix,1,2,0,4);*/










    }




}