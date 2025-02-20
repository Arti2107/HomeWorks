namespace Task2_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double n = Convert.ToDouble (Console.ReadLine());
            double n2 = Math.Ceiling (n);
           
            Console.WriteLine("Длина трубы: {0} ", n2);
            Console.Write("Нажмите любую клавишу");
            Console.ReadKey();
        }
    }
}
