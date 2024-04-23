using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wielowątkowoś
{
    internal class Matrix
    {
        public double[][] matrix;

        public Matrix(double[][] a)
        {
            matrix = a;
        }

        public void printTheMatrix()
        {
            for (int i = 0; i < matrix.Length; i++)
            {
                for (int j = 0; j < matrix[i].Length; j++)
                {
                    Console.Write(matrix[i][j] + "\t");
                }
                Console.WriteLine();
            }
        }
    }
}
