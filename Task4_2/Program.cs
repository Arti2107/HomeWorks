namespace Task4_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите натуральное число: ");
            int n = Convert.ToInt32(Console.ReadLine());
            if (n >= 0)
            {
                if (n > 0)
                {
                    if (n > 1)
                    {
                        double sum = 0;
                        for (double i = 1; i <= n; i++)
                        {
                            sum += (1 / i);
                        }
                        Console.WriteLine("1/1 + ... + 1/{0} = {1}", n, sum);
                    }
                    else
                    {
                        Console.WriteLine("1/1 = {0}", n);
                    }
                }
                else
                {
                    Console.WriteLine("Ошибка! Дробь 1/0 не определена");
                }
            }
            else
            {
                Console.WriteLine("Ошибка! Число {0} не натуральное", n);
            }
            Console.ReadKey();
        }
    }
}
