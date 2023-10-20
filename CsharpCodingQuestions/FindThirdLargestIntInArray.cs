using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpCodingQuestions
{
    class FindThirdLargestIntInArray
    {
        public static void FindThirdLargestIntegerInArray(int[] arr)
        {
            int max1 = int.MinValue;
            int max2 = int.MinValue;
            int max3 = int.MinValue;

            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] > max1)
                {
                    max3 = max2;
                    max2 = max1;
                    max1 = arr[i];
                }
                else if (arr[i] > max2 && arr[i] != max1)
                { 
                    max3 = max2;
                    max2 = arr[i];
                }
                else if(arr[i] > max3 && arr[i] != max2 && arr[i] != max1)
                {
                    max3 = arr[i];
                }
            }
            Console.WriteLine("The Third Largest Integer in Array is: " + max3);
        }
    }
}
