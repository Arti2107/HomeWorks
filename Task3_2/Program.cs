namespace Task3_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = Convert.ToInt32(Console.ReadLine());
            int b = Convert.ToInt32(Console.ReadLine());
            int c = Convert.ToInt32(Console.ReadLine());
            if (a > b && a > c)
            {
                Console.WriteLine("Наибольшее число: {0}", a);
            }
            else
            {
                if (b > a && b > c)
                {
                    Console.WriteLine("Наибольшее число: {0}", b);
                }
                else
                {
                    if (c > a && c > b)
                    {
                        Console.WriteLine("Наибольшее число: {0}", c);
                    }
                    else
                    {
                        Console.WriteLine("Ошибка! Введите разные числа");
                    }
                }
            }
            Console.ReadKey();
        }
    }
}