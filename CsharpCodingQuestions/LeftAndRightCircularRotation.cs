using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpCodingQuestions
{
    class LeftAndRightCircularRotation
    {
        /* Left circular rotation of an array:
         * The user will input an integer array and the method should shift each element of input array to its Left 
         * by one position in circular fashion. The logic is to iterate loop from Length-1 to 0 and swap each element with last element.
         * input: 1 2 3 4 5, output: 2 3 4 5 1
         */
        public static void RotateLeft(int[] array)
        {
            Console.WriteLine("Left circular rotation of an array.");
            int size = array.Length;
            int temp;

            for (int i = size - 1; i > 0; i--)
            {
                temp = array[array.Length - 1];
                array[array.Length - 1] = array[i - 1];
                array[i - 1] = temp;
            }

            foreach (var item in array)
            {
                Console.Write(item + " ");
            }
        }

        /* Right circular rotation of an array:
         * The user will input an integer array and the method should shift each element of input array to its Right by one position 
         * in circular fashion. The logic is to iterate loop from 0 to Length-1 and swap each element with first element.
         * input: 1 2 3 4 5, output: 5 1 2 3 4
         */

        public static void RotateRight(int[] array)
        {
            Console.WriteLine("\nRight circular rotation of an array.");
            int temp;

            for (int i = 0; i < array.Length - 1; i++)
            {
                temp = array[0];
                array[0] = array[i + 1];
                array[i + 1] = temp;
            }

            foreach (var item in array)
            {
                Console.Write(item + " ");
            }
        }
    }
}
