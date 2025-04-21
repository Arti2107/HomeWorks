using System.Reflection.Metadata;

namespace Task8_1
{
    internal class Program
    {
        static void Main()
        {
            int a = 0;
            int b = 0;
            try
            {
                Console.Write("Введите целое число: a = ");
                a = Convert.ToInt32(Console.ReadLine());
                Console.Write("Введите целое число: b = ");
                b = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Список операций: 1) a+b; 2) a-b; 3) a*b; 4) a/b");
                Console.Write("Выберите тип операции (1-4): ");
            }
            catch (FormatException)
            {
                Console.WriteLine($"Ошибка! Введите целое число");
            }
            try
            {
                int type = Convert.ToInt32(Console.ReadLine());
                if (type < 1 || type > 4)
                {
                    Console.WriteLine($"Ошибка! Данный тип операции не определен");
                }
                else
                {
                    if (type == 1)
                        Console.WriteLine($"Результат операции: {a} + {b} = {a + b}");
                    if (type == 2)
                        Console.WriteLine($"Результат операции: {a} - {b} = {a - b}");
                    if (type == 3)
                        Console.WriteLine($"Результат операции: {a} * {b} = {a * b}");
                    if (type == 4)
                        Console.WriteLine($"Результат операции: {a} / {b} = {a / b}");
                }
            }
            catch (FormatException)
            {
                Console.WriteLine($"Ошибка! Введите цифру от 1 до 4");
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine($"Ошибка! Деление на 0");
            }
            Console.ReadKey();
        }
    }
}
