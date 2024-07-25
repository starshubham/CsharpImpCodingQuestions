namespace CsharpImpCodingQuestions
{
    public class FindLargestNumberUsingPrompt
    {
        public static int LargestNumberInArray(int[] array)
        {
            int max = array[0];

            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] > max)
                    max = array[i];
            }

            // returns largest number
            return max;
        }
    }
}
