namespace Wielowątkowoś
{
    public class MatrixMultiplication
    {
        public static double[][] result;
        public static double[][] matrix1;
        public static double[][] matrix2;

        public MatrixMultiplication(double[][] a, double[][] b)
        {
            matrix1 = a;
            matrix2 = b;
        }
        public double[][] multiply(int amountOfThreads)
        {
            //printTheMatrix(matrix1);
            Console.WriteLine();
            //printTheMatrix(matrix2);
            Console.WriteLine();

            result = initTheMatrix(matrix1.Length);

            Thread[] threads = new Thread[amountOfThreads];

            int firstBorder = 0;
            int secondBorder = matrix1.Length / amountOfThreads;
            for (int i = 0; i < amountOfThreads; i++)
            {
                if (i == amountOfThreads - 1)
                {
                    int newFirstBorder = firstBorder;
                    int newSecondBorder = secondBorder;
                    threads[i] = new Thread(() => countThePartOfMatrix(newFirstBorder, (matrix1.Length - 1)));
                    threads[i].Name = (firstBorder + " " + (matrix1.Length - 1)).ToString();
                }
                else
                {
                    int newFirstBorder = firstBorder;
                    int newSecondBorder = secondBorder;
                    threads[i] = new Thread(() => countThePartOfMatrix(newFirstBorder, newSecondBorder));
                    threads[i].Name = (firstBorder + " " + secondBorder).ToString();
                }

                firstBorder = secondBorder + 1;
                secondBorder += matrix1.Length / amountOfThreads;
            }
            var watch = System.Diagnostics.Stopwatch.StartNew();
            foreach (Thread x in threads)
            {
                x.Start();
            }

            foreach (Thread x in threads)
            {
                x.Join();
            }
            watch.Stop();

            

            //printTheMatrix(result);

            Console.WriteLine($"threads ended in {watch.ElapsedMilliseconds} ms.");

            return result;

        }

        public static void countThePartOfMatrix(int givenStartThreadColumnNumber, int givenEndThreadColumnNumber)
        {
            for (int columnNumber = givenStartThreadColumnNumber; columnNumber <= givenEndThreadColumnNumber; columnNumber++)
            {
                /*lock (matrix2)
                {*/
                    for (int rowNumber = 0; rowNumber < matrix2.Length; rowNumber++)
                    {
                        double[] allRow = takeTheAllRowFromGivenMatrix(matrix1, columnNumber);
                        double[] allColumn = takeTheAllColumnFromGivenMatrix(matrix2, rowNumber);
                        double score = countTheGivenRowAndColumn(allRow, allColumn);
                        /*lock (result)
                        {*/
                            result[columnNumber][rowNumber] = score;
                        /*}*/
                    /*}*/
                }
            }
        }


        public static double countTheGivenRowAndColumn(double[] row, double[] column)
        {
            double sum = 0.0;

            for (int i = 0; i < row.Length; i++)
            {
                sum += row[i] * column[i];
            }

            return sum;
        }

        private static double[] takeTheAllRowFromGivenMatrix(double[][] matrix, int column)
        {
            /*lock (matrix)
            {*/
                double[] result = new double[matrix[column].Length];
                for (int i = 0; i < matrix[column].Length; i++)
                {
                    result[i] = matrix[column][i];
                }
                return result;
            /*}*/
        }

        private static double[] takeTheAllColumnFromGivenMatrix(double[][] matrix, int row)
        {
            /*lock (matrix)
            {*/
                double[] columnElements = new double[matrix[row].Length];

                for (int i = 0; i < matrix[row].Length; i++)
                {
                    columnElements[i] = matrix[i][row];
                }

                return columnElements;
            /*}*/
        }

        private static double[][] initTheMatrix(int length)
        {
            double[][] result = new double[length][];
            for (int i = 0; i < length; i++)
            {
                result[i] = new double[length];
                for (int j = 0; j < length; j++)
                {
                    result[i][j] = 0.0;
                }
            }
            return result;
        }

    }
}
