﻿namespace Task2_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());
            int a = n / 1000;
            int b = (n / 100) % 10;
            int c = (n / 10) % 10;
            int d = n % 10;
            int n2 = a * 1000 + d * 100 + c * 10 + b;
            Console.WriteLine("Исходное число: {0} ", n);
            Console.WriteLine("Результат преобразования: {0} ", n2);
            Console.Write("Нажмите любую клавишу");
            Console.ReadKey();
        }
    }
}