namespace Task4_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите числа a>0 и b>0: ");
            int a = Convert.ToInt32(Console.ReadLine());
            int b = Convert.ToInt32(Console.ReadLine());
            if ((a > 0) && (b > 0))
            {
                int sum = 1;
                for (int i = 1; i <= b; i++)
                {
                    sum *= a;
                }
                Console.WriteLine("a^b = {0}", sum);
            }
            else
            {
                Console.WriteLine("Ошибка! Число {0} и (или) {1} не больше нуля", a, b);
            }
            Console.ReadKey();
        }
    }
}
