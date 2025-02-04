using System;

namespace Scanner
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] numbers = { 1, -2, 3, 4, -5, 6 };

            double sum = CalculatePositiveSum(numbers);

            Console.WriteLine("Сумма положительных чисел: " + sum);
        }

        public static double CalculatePositiveSum(double[] arr)
        {
            double sum = 0;
            foreach (double num in arr)
            {
                if (num > 0)
                {
                    sum += num;
                }
            }
            return sum;
        }
    }
}
