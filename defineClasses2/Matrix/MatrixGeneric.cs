using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Matrix
{
   public class MatrixGeneric<T>where T:IComparable
    {
       private T[,] matrix;
       private int rows;
       private int cols;

       public MatrixGeneric(int rows, int cols)
       {
           this.Rows = rows;
           this.Cols = cols;
           this.matrix = new T[rows, cols];
       }
       public int Rows
       {
           get { return this.rows; }
           set { this.rows = value; }
       }
       public int Cols
       {
           get { return this.cols; }
           set { this.cols = value; }
       }
       public T this[int row,int col]
       {
           get
           {
               if (row>this.rows || row <0 || col>this.cols || col<0)
               {
                   throw new ArgumentOutOfRangeException("Out of the matrix."); 
               }
               T result = matrix[row, col];
               return result;
           }
           set
           {
               if (row<0 || col<0 || col>this.Cols || row>this.Rows)
               {
                   throw new ArgumentOutOfRangeException("Out of the matrix."); 
               }
               this.matrix[row, col] = value;
           }
       }
       public static MatrixGeneric<T> operator -(MatrixGeneric<T>firstMatrix,MatrixGeneric<T>secondMatrix)
       {
           MatrixGeneric<T> resultMatrix = new MatrixGeneric<T>(firstMatrix.Rows, firstMatrix.Cols);
           if (firstMatrix.Rows==secondMatrix.Cols && firstMatrix.Cols==secondMatrix.Rows)
           {
               for (int row = 0; row < firstMatrix.Rows; row++)
               {
                   for (int col = 0; col < firstMatrix.Cols; col++)
                   {
                       dynamic firstElement = firstMatrix[row, col];
                       dynamic secondElement = secondMatrix[row, col];
                       resultMatrix[row,col] = firstElement - secondElement;
                   }      
               }
           }
           else
           {
               throw new InvalidOperationException("The matrixs must be with equal rows and cols");
           }

           return resultMatrix;
       }
       public static MatrixGeneric<T> operator +(MatrixGeneric<T> firstMatrix,MatrixGeneric<T>secondMatrix)
       {
           MatrixGeneric<T> resultMatrix = new MatrixGeneric<T>(firstMatrix.Rows, firstMatrix.Cols);
           if (firstMatrix.Rows==secondMatrix.Rows && firstMatrix.Cols==secondMatrix.Cols)
           {
               for (int row = 0; row < firstMatrix.Rows; row++)
               {
                   for (int col = 0; col < firstMatrix.Cols; col++)
                   {
                       dynamic firstElement = firstMatrix[row, col];
                       dynamic secondElement = secondMatrix[row, col];
                       resultMatrix[row, col] = firstElement - secondElement;
                   }
               }
           }
           else
           {
               throw new InvalidOperationException("The matrixs are with diferent sizes");
           }
           return resultMatrix;
       }
       public static  MatrixGeneric<T> operator *(MatrixGeneric<T> firstMatrix,MatrixGeneric<T>secondMatrix)
       {
           MatrixGeneric<T> resultMatrix = new MatrixGeneric<T>(firstMatrix.Rows,firstMatrix.Cols);
          // int res = 0; ;
           if (firstMatrix.Rows == secondMatrix.Rows && firstMatrix.Cols == secondMatrix.Cols)
           {
               T res = (dynamic)0; 
              for (int row = 0; row < firstMatrix.Rows; row++)
               {
                  for (int col = 0; col < secondMatrix.Cols; col++)
                  {
                     for (int i = 0; i < firstMatrix.Cols; i++)
                      {     
                            res += (dynamic)firstMatrix[row, i] * secondMatrix[i, col] ;     
                       }
                      resultMatrix[row,col]=res;
                      res=(dynamic)0;
                      
                  }
             }
           }
      
           else
           {
               throw new InvalidOperationException("The matrixs can't be multiply.");
           }
           return resultMatrix;
       }
       public static bool operator true(MatrixGeneric<T>matrix)
       {
           if (matrix==null || matrix.Rows==0 || matrix.Cols==0)
           {
               return false;
           }
           for (int row = 0; row < matrix.Rows; row++)
           {
               for (int col = 0; col < matrix.Cols; col++)
               {
                   if (matrix[row,col]!=(dynamic)0)
                   {
                       return true;
                   }
               }
           }
           return false;
       }
       public static bool operator false(MatrixGeneric<T> matrix)
       {
           if (matrix == null || matrix.Rows == 0 || matrix.Cols == 0)
           {
               return true;
           }
           for (int row = 0; row < matrix.Rows; row++)
           {
               for (int col = 0; col < matrix.Cols; col++)
               {
                   if (matrix[row, col] != (dynamic)0)
                   {
                       return false;
                   }
               }
           }
           return true;
       }
       public override string ToString()
       {
           StringBuilder result = new StringBuilder();
           for (int row = 0; row < this.rows; row++)
           {
               for (int col = 0; col < this.cols; col++)
               {
                   result.Append(string.Format("{0,11}", this.matrix[row, col]));
               }
               result.Append(Environment.NewLine);
           }
           return result.ToString();
       }

    }
}
