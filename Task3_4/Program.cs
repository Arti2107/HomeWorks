namespace Task3_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = Convert.ToInt32(Console.ReadLine());
            int b = Convert.ToInt32(Console.ReadLine());
            int c = Convert.ToInt32(Console.ReadLine());
            if (a != b && a != c && b != c)
            {
                if (a > b && a > c)
                {
                    if (b > c)
                    {
                        Console.WriteLine("Медианное число: {0}", b);
                    }
                    else
                    {
                        Console.WriteLine("Медианное число: {0}", c);
                    }
                }
                else
                {
                    if (b > a && b > c)
                    {
                        if (a > c)
                        {
                            Console.WriteLine("Медианное число: {0}", a);
                        }
                        else
                        {
                            Console.WriteLine("Медианное число: {0}", c);
                        }
                    }
                    else
                    {
                        if (c > a && c > b)
                        {
                            if (a > b)
                            {
                                Console.WriteLine("Медианное число: {0}", a);
                            }
                            else
                            {
                                Console.WriteLine("Медианное число: {0}", b);
                            }
                        }
                    }
                }
            }
            else
            {
                Console.WriteLine("Ошибка! Введите разные числа");
            }
                Console.ReadKey();
            }
        }
    }