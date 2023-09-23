using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson1.Day1
{
    internal class ArreyDemo
    {
        public static void FirstMethod()
        {
            int[] sample = new int[10];
            //int a[] = new int[10]; // Illigal
            int i;
            for (i = 0; i < 10; i = i + 1)
                sample[i] = i * 5;
            for (i = 0; i < 10; i++)
                Console.WriteLine("sample[" + i + "]: " + sample[i]);
        }





        public static void SecondMethod()
        {
            int[] sample = new int[10];
            //int a[] = new int[10]; // Illigal
            int i;
            Random random = new Random();
            for (i = 0; i < 10; i = i + 1)
                sample[i] = random.Next(100);
            for (i = 0; i < 10; i++)
                Console.WriteLine("sample[" + i + "]: " + sample[i]);
            Console.WriteLine("Sum: " + sample.Sum());
            Console.WriteLine("Average: " + sample.Average());
            Console.WriteLine("Max: " + sample.Max());
            Console.WriteLine("Min: " + sample.Min());
        }



        public static void ArrayOverRun()
        {
            int[] sample = new int[10];
            int i;
            // Generate an array overrun.
            for (i = 0; i < 100; i = i + 1)
                sample[i] = i;
            //IndexOutOfRangeException
        }



        public static void WorkingWithCharArray()
        {
            string s1 = "Today is a very hot day";
            char[] data = s1.ToCharArray();
            int count = data.Length;
            Console.WriteLine("Array Length " + count);
            for (int i = 0; i < count; i++)
            {
                Console.WriteLine(data[i]);
            }
        }



        public static void TwoD()
        {
            int t, i;
            int[,] table = new int[3, 4];//3 Rows - 4 Col
            for (t = 0; t < 3; ++t)
            {
                for (i = 0; i < 4; ++i)
                {
                    table[t, i] = t * 4 + i + 1;
                    //Console.Write(table[t, i] + " ");
                }
                Console.WriteLine();
            }
        }


    }
}
