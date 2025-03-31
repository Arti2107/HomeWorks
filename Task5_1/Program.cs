using System;

namespace Task5_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const int n = 10;
            int[] array = new int[n];
            int a = 0;
            int b = 0;
            Random rnd = new Random();
            for (int i = 0; i < n; i++)
            {
                array[i] = rnd.Next(0, 101);
                Console.Write("{0} ", array[i]);
                if (array[i] % 2 == 0)
                {
                    a += 1;
                }
                else
                {
                    b += 1;
                }
            }
            Console.WriteLine();
            Console.WriteLine("Количество четных чисел: {0}, количество нечетных чисел: {1}", a, b);
            if (a == b)
            {
                Console.WriteLine("Количество четных и нечетных чисел одинаково");
            }
            else
            {
                if (a > b)
                {
                    Console.WriteLine("Четных чисел больше");
                }
                else
                {
                    Console.WriteLine("Нечетных чисел больше");
                }
            }
            Console.ReadKey();
        }
    }
}
