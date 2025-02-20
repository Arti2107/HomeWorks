namespace Task2_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double g = Convert.ToInt32(Console.ReadLine());
            double m = Convert.ToInt32(Console.ReadLine());
            double s = Convert.ToInt32(Console.ReadLine());

        double gradSum = g + m / 60 + s / 60 / 60;
            double rad = gradSum / 180 * Math.PI;

            Console.WriteLine("Значение в градусах: {0} ", gradSum);
            Console.WriteLine("Значение в радианах: {0} ", rad);
            Console.Write("Нажмите любую клавишу");
            Console.ReadKey();

        }
    }
}
