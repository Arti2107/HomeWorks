namespace Task2_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double d = Convert.ToInt32(Console.ReadLine());
            const double n = 2.54;
            double d1 = d * n * 10; // значение в миллиметрах без округления 

            double m = Math.Floor(d1 / 1000);
            double sm = Math.Floor(d1 % 1000 / 10);
            double mm = Math.Round(d1 % 10);

            Console.WriteLine("Значение в дюймах: {0}", d);
            Console.WriteLine("Результат перевода: {0} м {1} см {2} мм", m, sm, mm);
            Console.Write("Нажмите любую клавишу");
            Console.ReadKey();

        }
    }
}
