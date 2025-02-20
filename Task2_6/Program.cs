namespace Task2_6
{

    internal class Program
    {
        static void Main(string[] args)
        {
            double l = Convert.ToDouble(Console.ReadLine());

            double l2 = Math.Round(l * 2);
            double l3 = l2 / 2;


            Console.WriteLine("Длина трубы: {0} ", l3);
            Console.Write("Нажмите любую клавишу");
            Console.ReadKey();

        }
    }
}
