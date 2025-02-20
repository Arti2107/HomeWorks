namespace Task2_7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = Convert.ToInt32(Console.ReadLine());
            int b = Convert.ToInt32(Console.ReadLine());

            (a, b) = (b, a);
    
            Console.WriteLine("Результат: {0} {1}", a, b);
            Console.Write("Нажмите любую клавишу");
            Console.ReadKey();

        }
    }
}
