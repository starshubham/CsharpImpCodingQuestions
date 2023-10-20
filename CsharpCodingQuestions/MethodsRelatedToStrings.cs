using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpCodingQuestions
{
    class MethodsRelatedToStrings
    {
        public static string ReverseString()
        {
            Console.WriteLine("\nPlease Enter a string to Reverse: ");
            string str = Console.ReadLine();

            char[] charArray = str.ToCharArray();
            string revString = string.Empty;

            for (int i = charArray.Length - 1; i >= 0; i--)
            {
                revString = revString + charArray[i];
            }
            return revString;
        }

        public static string ReverseStringUsingStringBuilder()
        {
            Console.WriteLine("\nPlease Enter a string to Reverse using String Builder: ");
            string str = Console.ReadLine();

            StringBuilder builder = new StringBuilder();

            for (int i = str.Length - 1; i >= 0; i--)
            {
                builder.Append(str[i]);
            }
            return builder.ToString();
        }

        public static void StringPalindrome()
        {
            Console.WriteLine("\nPlease Enter a string to check for Palindrome: ");
            string str = Console.ReadLine();
            string revString = "";

            for (int i = str.Length - 1; i >= 0; i--)
            {
                revString = revString + str[i];
            }
            if (str == revString)
            {
                Console.WriteLine($"{str} is a Palindrome.");
            }
            else
                Console.WriteLine($"{str} is not a Palindrome.");
        }

        public static void ReverseEachWordInString()
        {
            // input: Hi World -->   output: iH dlroW
            // Method-1
            // Without using any built-in function:
            Console.Write("\nEnter a Sentence to reversed each word string : ");
            string str = Console.ReadLine();
            string revEachWordofString = "";

            foreach(var word in str.Split(" "))
            {
                string temp = "";
                foreach(var ch in word.ToCharArray())
                {
                    temp = ch + temp;
                }
                revEachWordofString = revEachWordofString + temp + " ";
            }
            Console.WriteLine(revEachWordofString);

            // Method-2
            // Using Linq to Reverse Each Word in C#
            Console.WriteLine("\nReverse each word of the string using Linq: ");
            Console.Write("Enter a Sentence to reversed each word string : ");
            string originalString = Console.ReadLine();

            string reverseEachWordString = string.Join(' ', originalString.Split(' ').Select(x => new string(x.Reverse().ToArray())));
            Console.WriteLine($"Reversed Word String : {reverseEachWordString}");
        }

        public static void CountOccurrenceOfEachChar()
        {
            Console.WriteLine("\nEnter the string to count occurrence of each character: ");
            string str = Console.ReadLine();

            Dictionary<char, int> charCount = new Dictionary<char, int>();

            foreach (var character in str)
            {
                if(character != ' ')
                {
                    if (!charCount.ContainsKey(character))
                    {
                        charCount.Add(character, 1);
                    }
                    else
                    {
                        charCount[character]++;
                    }
                }
            }
            foreach (var character in charCount)
            {
                Console.WriteLine("{0} - {1}", character.Key, character.Value);
            }
        }

        public static void RemoveDuplicateChar()
        {
            Console.WriteLine("\nEnter the string to remove duplicate characters from string: ");
            string str = Console.ReadLine();
            string result = string.Empty;

            for (int i = 0; i < str.Length; i++)
            {
                if (!result.Contains(str[i]))
                    result += str[i];
            }
            Console.WriteLine("String after removing duplicate character: " + result);
        }

        public static void FindAllSubString()
        {
            Console.WriteLine("\nEnter the string to find its all possible substrings: ");
            string str = Console.ReadLine();

            for (int i = 0; i < str.Length; i++)
            {
                StringBuilder subString = new StringBuilder();
                for (int j = i; j < str.Length; j++)
                {
                    subString.Append(str[j]);
                    Console.Write(subString + " ");
                }
            }
        }

        public static void ReverseWordOrder()
        {
            // Method-1
            Console.WriteLine("\nEnter the sentence to reverse the order of words: ");
            string str = Console.ReadLine();

            int i;
            StringBuilder reverseSentence = new StringBuilder();

            int Start = str.Length - 1;
            int End = str.Length - 1;

            while (Start > 0)
            {
                if (str[Start] == ' ')
                {
                    i = Start + 1;
                    while (i <= End)
                    {
                        reverseSentence.Append(str[i]);
                        i++;
                    }
                    reverseSentence.Append(' ');
                    End = Start - 1;
                }
                Start--;
            }

            for (i = 0; i <= End; i++)
            {
                reverseSentence.Append(str[i]);
            }
            Console.WriteLine(reverseSentence.ToString());


            // Method-2
            Console.WriteLine("\nReversing the order of words using build-in methods: ");
            // Split the input string into words using space as the delimiter
            string[] words = str.Split(' ');

            // Reverse the order of words
            Array.Reverse(words);

            // Join the reversed words into a single string
            string reversedString = string.Join(" ", words);

            // Output the reversed string
            Console.WriteLine(reversedString);
        }
    } 
}
