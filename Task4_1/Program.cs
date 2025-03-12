namespace Task4_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите натуральное число: ");
            int n = Convert.ToInt32(Console.ReadLine());
            if (n >= 0)
            {
                int nFact = 1;
                for (int i = 1; i <= n; i++)
                {
                    nFact *= i;
                }
                Console.WriteLine("{0}! = {1}", n, nFact);
            }
            else
            {
                Console.WriteLine("Ошибка! Число {0} не натуральное", n);
            }
            Console.ReadKey();
        }
    }
}
