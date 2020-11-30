using System;
using System.Diagnostics;

namespace Radix_Sort
{
    class Program
    {
        static void Main(string[] args)
        {
            //Test
            RadixSort(132, 18, 9, 56, 72, 212, 3);
        }

        public static void RadixSort(params int[] Array)
        {
            int max = Array[0];
            for (int i = 0; i < Array.Length; i++)
            {
                if (Array[i] > max)
                {
                    max = Array[i];
                }
            }
            for (int i = 1; max / i > 0; i *= 10)
            {
                countingsort(Array, i);
            }
            Console.WriteLine(string.Join(" ", Array));

        }
        public static void countingsort(int[] numbers, int place) // 132, 18, 9, 56, 72, 212, 3
        {                          //0, 1, 2, 3, 4, 5, 6, 7, 8, 9 - index
            int[] freq = new int[] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };
            int lenght = numbers.Length;
            int[] output = new int[lenght];
            for (int i = 0; i < lenght; i++)
            {
                freq[(numbers[i] / place) % 10]++;
            }
            //Result
            // freq - 0,0,3,1,0,0,1,0,1,1
            for (int i = 1; i < freq.Length; i++)
            {
                freq[i] += freq[i - 1];
            }
            //Result
            // freq - 0,0,3,4,4,4,5,5,6,7
            for (int i = lenght - 1; i >= 0; i--)
            {
                output[freq[(numbers[i] / place) % 10] - 1] = numbers[i];
                /// output - 132,72,212,3,56,18,9
                freq[(numbers[i] / place) % 10]--;
            }
            for (int i = 0; i < lenght; i++)
            {
                numbers[i] = output[i];
            }
        }
        
    }
}
