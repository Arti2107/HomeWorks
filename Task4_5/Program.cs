namespace Task4_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a;
            do
            {
                Console.WriteLine("Введите число из отрезка [20; 60]: ");
                a = Convert.ToInt32(Console.ReadLine());
            }
            while ((a < 20) || (a > 60));
                        Console.WriteLine("Верно! 20 <= {0} <= 60", a);
            Console.ReadKey();
        }
    }
}
