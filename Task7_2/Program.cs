using System.Reflection.Metadata;

namespace Task7_2
{
    internal class Program
    {
        static void Main()
        {
            Console.Write("Введите длину ребра куба: a = ");
            double a = Convert.ToDouble(Console.ReadLine());
            double volume;
            double surfaceArea;
            CalcCube(a, out volume, out surfaceArea);

            Console.WriteLine($"Объем куба: {volume}");
            Console.WriteLine($"Площадь полной поверхности куба: {surfaceArea}");
            Console.ReadKey();
        }
        static void CalcCube(double a, out double volume, out double surfaceArea)
        {
            volume = Math.Pow(a, 3);
            surfaceArea = 6 * Math.Pow(a, 2);
        }
    }
}