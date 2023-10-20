using System;

namespace CsharpCodingQuestions
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter your Choice: ");
            Console.WriteLine("\n1.Find Second Largest Integer in an array" +
                "\n2.Find Third Largest Integer in an array" +
                "\n3.Check the given number is Prime or not" +
                "\n4.Find Factorial of a Number" +
                "\n5.Methods related to strings" +
                "\n6.Methods related to numbers" +
                "\n7.Left and Right Circular Rotation" +
                "\n8.Convert 2-D array to 1-D and vice-versa" + 
                "\n9.Find angle between hour and minute hands of a clock at any given time" +
                "\n10. Bubble Sort");

            int Choice = int.Parse(Console.ReadLine());

            switch (Choice)
            {
                case 1:
                    int[] inputArr1 = { 3, 2, 1, 5, 4 };
                    FindSecondLargestIntegerInArray.FindSecondLargestIntInArray(inputArr1);
                    int largestNum = FindSecondLargestIntegerInArray.LargestNumberInArray(inputArr1);
                    Console.WriteLine("Largest integer is: " + largestNum);
                    break;
                case 2:
                    int[] inputArr2 = { 3, 2, 1, 5, 4, 6 };
                    FindThirdLargestIntInArray.FindThirdLargestIntegerInArray(inputArr2);
                    break;
                case 3:
                    CheckNumberIsPrime.CheckPrimeNumber();
                    break;
                case 4:
                    Console.Write("Please Enter a number to get its factorial: ");
                    int n1 = Convert.ToInt32(Console.ReadLine());
                    long fact = FactorialOf_A_Number.FindFactorialOfNumber(n1);
                    Console.WriteLine("The factorial of {0} is: {1} ", n1, fact);
                    break;
                case 5:
                    var str1 = MethodsRelatedToStrings.ReverseString();
                    Console.WriteLine("Reversed String is: " + str1);

                    var str2 = MethodsRelatedToStrings.ReverseStringUsingStringBuilder();
                    Console.WriteLine("Reversed String is: " + str2);

                    MethodsRelatedToStrings.StringPalindrome();

                    MethodsRelatedToStrings.ReverseEachWordInString();

                    MethodsRelatedToStrings.CountOccurrenceOfEachChar();

                    MethodsRelatedToStrings.RemoveDuplicateChar();

                    MethodsRelatedToStrings.FindAllSubString();

                    MethodsRelatedToStrings.ReverseWordOrder();
                    break;
                case 6:
                    MethodsRelatedToNumber methodsRelatedToNumber = new MethodsRelatedToNumber();
                    methodsRelatedToNumber.FibonacciSeries();

                    methodsRelatedToNumber.ReverseNumber();

                    methodsRelatedToNumber.NumberPalindrome();

                    methodsRelatedToNumber.SumOfDigits();
                    break;
                case 7:
                    int[] arr1 = { 1, 2, 3, 4, 5 };
                    LeftAndRightCircularRotation.RotateLeft(arr1);

                    int[] arr2 = { 1, 2, 3, 4, 5 };
                    LeftAndRightCircularRotation.RotateRight(arr2);
                    break;
                case 8:
                    int[,] arr3 = { { 1, 2, 3 }, { 4, 5, 6 } };
                    ConversionBetween1D_ArrayTo2D_ArrayViceVersa.MultiToSingle(arr3);

                    int[] arr4 = { 1, 2, 3, 4, 5, 6 };
                    int row = 2;
                    int column = 3;
                    ConversionBetween1D_ArrayTo2D_ArrayViceVersa.SingleToMulti(arr4, row, column);
                    break;
                case 9:
                    Console.Write("Please Enter hours: ");
                    int hours = int.Parse(Console.ReadLine());

                    Console.Write("Please Enter minutes: ");
                    int minutes = int.Parse(Console.ReadLine());

                    AngleBtwHourAndMinuteHandsOfClock.FindAngleinTime(hours, minutes);
                    break;
                case 10:
                    int[] arr = { 64, 34, 25, 12, 22, 11, 90 };
                    Console.WriteLine("Unsorted Array: ");
                    Bubble_Sort.PrintArray(arr);

                    Bubble_Sort.BubbleSort(arr);
                    Console.WriteLine("\nSorted Array: ");
                    Bubble_Sort.PrintArray(arr);
                    break;
                default:
                    Console.WriteLine("Please Enter a Valid Key.");
                    break;
            }
        }
    }
}
