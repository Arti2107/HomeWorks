using static System.Runtime.InteropServices.JavaScript.JSType;
using System.Numerics;

namespace Task3_7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = Convert.ToInt32(Console.ReadLine());
            int absoluteValue = a;
            if (a < 0)
            {
                absoluteValue = -a;
            }
            if ((absoluteValue / 100 == 0) && (absoluteValue / 10 > 0))
            {
                Console.WriteLine("Ответ: Да");
            }
            else
            {
                Console.WriteLine("Ответ: Нет");
            }
            Console.ReadKey();
        }
    }
}
