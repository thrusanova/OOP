using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Matrix
{
    class TestMatrix
    {
        static void Main()
        {
            MatrixGeneric<int> matrix1 = new MatrixGeneric<int>(3, 3);
            MatrixGeneric<int> matrix2 = new MatrixGeneric<int>(3, 3); 
           
            for (int row = 0; row < matrix1.Rows; row++)
            {
               
                for (int col = 0; col < matrix1.Cols; col++)
                {
                    matrix1[row, col] = row + 1;
                }
            }
            Console.WriteLine("FirstMatrix is:");
            Console.WriteLine(matrix1);
            for (int row = 0; row < matrix2.Rows; row++)
            {

                for (int col = 0; col < matrix2.Cols; col++)
                {
                    matrix2[row, col] = row;
                }
            }
            Console.WriteLine("SecondMatrix is:");
            Console.WriteLine(matrix2);
            MatrixGeneric<int> SumOfMatrix = matrix1 + matrix2;
            Console.WriteLine("SumMatrix is:");
            Console.WriteLine(SumOfMatrix);
            MatrixGeneric<int> SubStactMatrix = matrix1 - matrix2;
            Console.WriteLine("Substract Matrix is:");
            Console.WriteLine(SubStactMatrix);
            MatrixGeneric<int> MultiplyMatrix = matrix1 * matrix2;
            Console.WriteLine("Multiply matrix is:");
            Console.WriteLine(MultiplyMatrix);
            var hasZero = matrix2 ? false : true;
            Console.WriteLine("Second Matrix has zeroes: {0}", hasZero);

        }
    }
}
