using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpCodingQuestions
{
    class CheckNumberIsPrime
    {
        public static void CheckPrimeNumber()
        {
            int n, i, flag = 0;
            Console.WriteLine("Please Enter a number to check for Prime Number: ");
            n = int.Parse(Console.ReadLine());

            for (i = 2; i <= n/2; i++)
            {
                if(n % i == 0)
                {
                    Console.WriteLine($"{n} is not a Prime Number");
                    flag = 1;
                    break;
                }
            }
            if (n == 1 || flag == 1)
            {
                Console.WriteLine($"{n} is not a Prime Number");
            }
            else if (flag == 0)
            {
                Console.WriteLine($"{n} is a Prime Number");
            }
        }
    }
}
