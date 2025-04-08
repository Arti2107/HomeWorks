namespace Task7_5
{
    internal class Program
    {
        static void Main()
        {
            Console.Write("Введите первое целое число: a1 = ");
            int a1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите второе целое число: b1 = ");
            int b1 = Convert.ToInt32(Console.ReadLine());
            int result1 = Multiply(a1, b1);
            Console.WriteLine($"{a1} * {b1} = {result1}");

            Console.Write("Введите первое дробное число: a2 = ");
            double a2 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите второе дробное число: b2 = ");
            double b2 = Convert.ToDouble(Console.ReadLine());
            double result2 = Multiply(a2, b2);
            Console.WriteLine($"{a2} * {b2} = {result2}");

            Console.ReadKey();
        }
        static int Multiply(int number1, int number2)
        {
            return number1 * number2;
        }
        static double Multiply(double number1, double number2)
        {
            return number1 * number2;
        }
    }
}