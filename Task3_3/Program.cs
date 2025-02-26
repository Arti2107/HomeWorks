namespace Task3_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = Convert.ToInt32(Console.ReadLine());
            int b = Convert.ToInt32(Console.ReadLine());
            int c = Convert.ToInt32(Console.ReadLine());
            int d = Convert.ToInt32(Console.ReadLine());
            if (a > b && a > c && a > d)
            {
                Console.WriteLine("Наибольшее число: {0}", a);
            }
            else
            {
                if (b > a && b > c && b > d)
                {
                    Console.WriteLine("Наибольшее число: {0}", b);
                }
                else
                {
                    if (c > a && c > b && c > d)
                    {
                        Console.WriteLine("Наибольшее число: {0}", c);
                    }
                    else
                    {
                        if (d > a && d > b && d > c)
                        {
                            Console.WriteLine("Наибольшее число: {0}", d);
                        }
                        else
                        {
                            Console.WriteLine("Ошибка! Введите разные числа");
                        }
                    }
                }
            }
            Console.ReadKey();
        }
    }
}