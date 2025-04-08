namespace Task7_1
{
    internal class Program
    {
        static void Main()
        {
            Console.Write("Введите стороны первого треугольника: a1 = ");
            double a1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("b1 = ");
            double b1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("c1 = ");
            double c1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите стороны второго треугольника: a2 = ");
            double a2 = Convert.ToDouble(Console.ReadLine());
            Console.Write("b2 = ");
            double b2 = Convert.ToDouble(Console.ReadLine());
            Console.Write("c2 = ");
            double c2 = Convert.ToDouble(Console.ReadLine());

            double result1 = Square(a1, b1, c1);
            double result2 = Square(a2, b2, c2);
            Console.WriteLine($"Площадь первого треугольника S1 = {result1:f2}, площадь второго треугольника S2 = {result2:f2}");
            if (result1 != result2)
            {
                if (result1 > result2)
                {
                    Console.WriteLine($"Площадь первого треугольника больше, S1 = {result1:f2}");
                }
                else
                {
                    Console.WriteLine($"Площадь второго треугольника больше, S2 = {result2:f2}");
                }
            }
            else
            {
                Console.WriteLine("Площади треугольников равны");
            }
            Console.ReadKey();
        }
        static double Square(double number1, double number2, double number3)
        {
            double p = (number1 + number2 + number3) / 2;
            return Math.Sqrt(p * (p - number1) * (p - number2) * (p - number3));
        }
    }
}