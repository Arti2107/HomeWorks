namespace Task4_8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            {
                Console.Write("Введите положительное число: ");
                int a = Convert.ToInt32(Console.ReadLine());
                if (a > 0)
                {
                    int n = 1;
                    int a2 = a; // Число равное исходному для работы цикла n раз
                    while (a2 / 10 != 0)
                    {
                        a2 /= 10;
                        n++;
                    }
                    double b = 0;
                    int a3 = a; // Число равное исходному для работы цикла n раз
                    do
                    {
                        n--;
                        b = b + (a3 % 10) * (Math.Pow(10, n));
                        a3 /= 10;
                    }
                    while (n != 0);

                    Console.WriteLine("Исходное число: {0}, зеркальное число: {1}", a, b);
                }
                else
                {
                    Console.WriteLine("Число {0} не положительное", a);
                }
            }
            Console.ReadKey();

        }
    }
}