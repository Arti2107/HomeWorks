namespace Task4_6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            {
                Console.Write("Введите число: ");
                double a = Convert.ToDouble(Console.ReadLine());
                if (a < 1)
                {
                    Console.WriteLine("Число {0} не является степенью 2", a);
                }
                if (a == 1)
                {
                    Console.WriteLine("Число {0} является степенью 2: 2^0 = {0}", a);
                }
                else
                {
                    double a2 = a;
                    int x = 0;
                    while ((a2 != 1) && (a % 2 == 0))
                    {
                        a2 /= 2;
                        x++;
                    }
                    if (a % 2 == 1)
                    {
                        Console.WriteLine("Число {0} не является степенью 2", a);
                    }
                    else
                    {
                        Console.WriteLine("Число {0} является степенью 2: 2^{1} = {0}", a, x);
                    }
                }
                Console.ReadKey();
            }
        }
    }
}