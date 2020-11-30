using System;

namespace BubbleSort
{
    class Program
    {
        static void Main(string[] args)
        {
            BubbleSort(9, 4, 2, 7, 2, 6, 8, 0, 4);
        }
        public static void BubbleSort(params double[] numbers)
        {
            for(int i = 0;i<numbers.Length;i++)
            {
                for(int k = i+1;k<numbers.Length;k++)
                {
                    if(numbers[i]>numbers[k])
                    {
                        double a = numbers[i];
                        numbers[i] = numbers[k];
                        numbers[k] = a;
                        i = 0;
                    }
                }
            }
            Console.WriteLine(string.Join(" ",numbers));
        }
    }
}
