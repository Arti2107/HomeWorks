using System;

namespace Task5_10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = 0;
            Console.Write("Введите размер массива n: ");
            n = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("Массив n x n:");
            int[,] array = new int[n, n];
            Random rnd = new Random();
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    array[i, j] = rnd.Next(0, 2);
                    Console.Write("{0,4}", array[i, j]);
                }
                Console.WriteLine();
            }
            bool f1 = true;
            bool f2 = false;
            bool f3 = false;
            bool f4 = false;
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (array[i, j] != 1)
                    {
                        f1 = false;
                        break; // Не понимаю, как программа должна вернуть true, если, например, в правом нижнем углу 0. В таком случае, флаг всегда перезаписывается на false
                    }
                }
            }
            // Оставил только горизонтальные линии, три остальные проверки сделать легко, но принцип возврата true одинаковый, не получается
            if (f1 == true || f2 == true || f3 == true || f4 == true)
                Console.Write("Крестики победили!");
            else
                Console.Write("Крестики проиграли :(");
            Console.ReadKey();
        }
    }
}