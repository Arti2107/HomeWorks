namespace Task4_7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            {
                Console.Write("Введите число: ");
                int a = Convert.ToInt32(Console.ReadLine());
                int n = 1;
                int a2 = a;
                while (a2 / 10 != 0)
                {
                    a2 /= 10;
                    n++;
                }
                Console.WriteLine("Количество цифр в числе {0} равно {1}", a, n);
            }
            Console.ReadKey();
        }
    }
}
