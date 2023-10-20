using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpCodingQuestions
{
    class Bubble_Sort
    {
        /* Bubble Sort Algorithm In C#
        This algorithm follows the concept of iterating through the array from the first index to the last index and comparing adjacent 
        elements and then swapping them if they appear in the wrong order. i.e. If the next element is smaller than the current element,
        they are swapped. 

        Let us understand this with the help of an example. Let us take an input array such as – 8 5 7 3 1

        The sorted output for this array is – 1 3 5 7 8

        Let us see the step by step execution of the Bubble sort algorithm on the input array to get the sorted output.

         Iteration 1: – 8 5 7 3 1 → 5 8 7 3 1 → 5 7 8 3 1 → 5 7 3 8 1→ 5 7 3 1 8
         Iteration 2: – 5 7 3 1 8 → 5 3 7 1 8→ 5 3 1 7 8
         Iteration 3: – 5 3 1 7 8 → 3 5 1 7 8 → 3 1 5 7 8
         Iteration 4: – 3 1 5 7 8 → 1 3 5 7 8
         Iteration 5: – 1 3 5 7 8
        Hence, we got the sorted array in iteration 5.
         */

        public static void BubbleSort(int[] arr)
        {
            int arrLength = arr.Length;

            for (int i = 0; i < arrLength - 1; i++)
            {
                for (int j = 0; j < arrLength - 1 - i; j++)
                {
                    if (arr[j] > arr[j + 1])
                    {
                        // Swap arr[j] and arr[j+1]
                        int temp = arr[j];
                        arr[j] = arr[j + 1];
                        arr[j + 1] = temp;
                    }
                }
            }
        }

        public static void PrintArray(int[] arr)
        {
            foreach (var item in arr)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();
        }
    }
}
