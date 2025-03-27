using System.Text;

namespace Task6_3
{
    internal class Program
    {
        static void Main()
        {
            Console.Write("Введите отчетный месяц: ");
            string month = Console.ReadLine();
            StringBuilder monthResult = new StringBuilder();
            if (!string.IsNullOrEmpty(month))
                monthResult.Append(char.ToUpper(month[0]) + month.Substring(1));
            Console.Write("Введите отчетный год: ");
            string year = Console.ReadLine();
            Console.Write("Введите общую сумму продаж (р.): ");
            double sum = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите количество проданных товаров (шт.): ");
            double quantity = Convert.ToDouble(Console.ReadLine());
            double mid = sum/quantity;
            string s1 = new String('-', 32);
            Console.WriteLine(s1);
            Console.WriteLine("Отчет о продажах за {0} {1} г.", monthResult, year);
            Console.WriteLine(s1);
            Console.WriteLine("Общая сумма продаж: {0:.00} р.", sum);
            Console.WriteLine("Количество проданных товаров: {0} шт.", quantity);
            Console.WriteLine("Средняя стоимость товара: {0:.00} р.", mid);
            Console.WriteLine(s1);
            Console.ReadKey();
        }
    }
}