namespace CsharpImpCodingQuestions
{
    class FactorialOf_A_Number
    {
        public static long FindFactorialOfNumber(int n)
        {
            if (n == 0)
            {
                return 1;
            }
            return n * FindFactorialOfNumber(n - 1);
        }
    }
}
