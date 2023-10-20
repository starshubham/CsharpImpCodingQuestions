using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpCodingQuestions
{
    class MethodsRelatedToNumber
    {
        public void FibonacciSeries()
        {
            int n1 = 0, n2 = 1, n3, number;
            Console.Write("Enter the number of elements for Fibonacci Series: ");
            number = int.Parse(Console.ReadLine());
            Console.Write(n1 + " " + n2 + " ");       //printing 0 and 1  and it is base condition

            for (int i = 2; i < number; i++)          //loop starts from 2 because 0 and 1 are already printed
            {
                n3 = n1 + n2;
                Console.Write(n3 + " ");
                n1 = n2;
                n2 = n3;
            }
        }

        public void ReverseNumber()
        {
            int n, reverse = 0, rem;
            Console.WriteLine("\n\nEnter a number to reverse it: ");
            n = int.Parse(Console.ReadLine());

            while(n > 0)
            {
                rem = n % 10;
                reverse = (reverse * 10) + rem;
                n = n / 10;
            }
            Console.WriteLine("Reversed number is: " + reverse);
        }

        public void NumberPalindrome()
        {
            int num, reverse = 0, rem;
            Console.WriteLine("\nEnter a number to check it for Palindrome: ");
            num = int.Parse(Console.ReadLine());
            int temp = num;
            while(num > 0)
            {
                rem = num % 10;
                reverse = reverse * 10 + rem;
                num = num / 10;
            }
            if (temp == reverse)
            {
                Console.WriteLine($"{temp} is a Palindrome Number.");
            }
            else
            {
                Console.WriteLine($"{temp} is not a Palindrome Number.");
            }
        }

        public void SumOfDigits()
        {
            int num, sum = 0;
            Console.WriteLine("\nEnter a number to find its sum of digits: ");
            num = Convert.ToInt32(Console.ReadLine());
            
            while(num > 0)
            {
                sum = sum + num % 10;
                num = num / 10;
            }
            Console.WriteLine("Sum of digits of given number is: " + sum);
        }
    }
}
