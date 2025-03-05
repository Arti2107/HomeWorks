namespace Task4_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите числа a>0 и b<0: ");
            int a = Convert.ToInt32(Console.ReadLine());
            int b = Convert.ToInt32(Console.ReadLine());
            if ((a > 0) && (b < 0))
            {
                int bAbs = -b;
                double sum = 1;
                for (int i = 1; i <= bAbs; i++)
                {
                    sum *= a;
                }
                double sum2 = 1 / sum;
                Console.WriteLine("a^b = {0}", sum2);
            }
            else
            {
                Console.WriteLine("Ошибка! Число {0} не больше нуля и (или) число {1} не меньше нуля", a, b);
            }
            Console.ReadKey();
        }
    }
}
