using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpCodingQuestions
{
    class FindSecondLargestIntegerInArray
    {
        public static void FindSecondLargestIntInArray(int[] arr)
        {
            int max1 = int.MinValue;
            int max2 = int.MinValue;

            foreach(int element in arr)
            {
                if (element > max1)
                { 
                    max2 = max1;
                    max1 = element;
                }
                else if (element >= max2 && element != max1)
                {
                    max2 = element;
                }
            }
            Console.WriteLine("The Second Largest number is: " + max2);
        }

        public static int LargestNumberInArray(int[] arr)
        {
            // Assum largest number is first element
            int max = arr[0];

            // Traverse array elements from second element and
            // compare every element with current max 
            for (int i = 1; i < arr.Length; i++)
            {
                if (max < arr[i])
                {
                    max = arr[i];
                }
            }
            return max;
        }
    }
}
