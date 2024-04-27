namespace Wielowątkowoś
{
    public class MatrixMultiplication
    {
        public static int[][] result;
        public static int[][] matrix1;
        public static int[][] matrix2;

        public MatrixMultiplication(int[][] a, int[][] b)
        {
            matrix1 = a;
            matrix2 = b;
        }

        public int[][] multiply(int amountOfThreads)
        {
           /* printTheMatrix(matrix1);
            Console.WriteLine();
            printTheMatrix(matrix2);
            Console.WriteLine();*/

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


            Console.WriteLine($"threads ended in {watch.ElapsedMilliseconds} ms.");
            /*Console.WriteLine($"{watch.ElapsedMilliseconds}");*/

            return result;

        }

        public static void countThePartOfMatrix(int givenStartThreadColumnNumber, int givenEndThreadColumnNumber)
        {
            for (int columnNumber = givenStartThreadColumnNumber; columnNumber <= givenEndThreadColumnNumber; columnNumber++)
            {

                for (int rowNumber = 0; rowNumber < matrix2.Length; rowNumber++)
                {
                    int[] allRow = takeTheAllRowFromGivenMatrix(matrix1, columnNumber);
                    int[] allColumn = takeTheAllColumnFromGivenMatrix(matrix2, rowNumber);
                    int score = countTheGivenRowAndColumn(allRow, allColumn);

                    result[columnNumber][rowNumber] = score;
                }
            }
        }


        public static int countTheGivenRowAndColumn(int[] row, int[] column)
        {
            int sum = 0;

            for (int i = 0; i < row.Length; i++)
            {
                sum += row[i] * column[i];
            }

            return sum;
        }

        private static int[] takeTheAllRowFromGivenMatrix(int[][] matrix, int column)
        {

            int[] result = new int[matrix[column].Length];
            for (int i = 0; i < matrix[column].Length; i++)
            {
                result[i] = matrix[column][i];
            }
            return result;

        }

        private static int[] takeTheAllColumnFromGivenMatrix(int[][] matrix, int row)
        {

            int[] columnElements = new int[matrix[row].Length];

            for (int i = 0; i < matrix[row].Length; i++)
            {
                columnElements[i] = matrix[i][row];
            }
            return columnElements;
        }

        private static int[][] initTheMatrix(int length)
        {
            int[][] result = new int[length][];
            for (int i = 0; i < length; i++)
            {
                result[i] = new int[length];
                for (int j = 0; j < length; j++)
                {
                    result[i][j] = 0;
                }
            }
            return result;
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
}
