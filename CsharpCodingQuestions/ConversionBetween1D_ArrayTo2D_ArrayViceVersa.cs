using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpCodingQuestions
{
    class ConversionBetween1D_ArrayTo2D_ArrayViceVersa
    {
        /* Convert a two-dimensional array to a one-dimensional array:
         * The user will input a 2-D array (matrix) and we need to convert it to a 1-D array. We will create a 1-D array column-wise.
         * input: { { 1, 2, 3 }, { 4, 5, 6 } }, output: 1 4 2 5 3 6
         */

        internal static void MultiToSingle(int[,] array)
        {
            int index = 0;
            int width = array.GetLength(0);  // GetLength(0) gives you the number of rows (the first dimension)
            int height = array.GetLength(1); // GetLength(1) gives you the number of columns (the second dimension) in the 2D array
            int[] single = new int[width * height];
            //// Column-wise Conversion
            //Console.WriteLine("Convert 2-D array to 1-D Column-wise: ");
            //for (int y = 0; y < height; y++)
            //{
            //    for (int x = 0; x < width; x++)
            //    {
            //        single[index] = array[x, y];
            //        Console.Write(single[index] + " ");
            //        index++;
            //    }
            //}

            // Row-wise Conversion
            Console.WriteLine("\nConvert 2-D array to 1-D Row-wise: ");
            for (int x = 0; x < width; x++)
            {
                for (int y = 0; y < height; y++)
                {
                    single[index] = array[x, y];
                    Console.Write(single[index] + " ");
                    index++;
                }
            }
        }


        /* convert a one-dimensional array to a two-dimensional array:
         * The user will input a 1-D array along with the number of rows and columns. The method should convert this 1-D array 
         * to a 2-D array(matrix) of a given row and column. We will create a matrix row-wise.
         * input: {1, 2, 3, 4, 5, 6} ,2 ,3
         * output: 1 2 3
         *         4 5 6
         */

        internal static void SingleToMulti(int[] array, int row, int column)
        {
            int index = 0;
            int[,] multi = new int[row, column];

            if (row * column != array.Length)
            {
                Console.WriteLine("\nInvalid dimensions for conversion.");
            }
            else
            {
                Console.WriteLine("\nConvert 1-D array to 2-D Row-wise: ");
                for (int x = 0; x < row; x++)
                {
                    for (int y = 0; y < column; y++)
                    {
                        multi[x, y] = array[index];
                        index++;
                        Console.Write(multi[x, y] + " ");
                    }
                    Console.WriteLine();
                }
            }
            
        }
    }
}
