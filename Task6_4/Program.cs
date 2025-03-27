using System.Text;

namespace Task6_4
{
    internal class Program
    {
        static void Main()
        {
            Console.Write("Введите имя: ");
            string name = Console.ReadLine();
            StringBuilder nameResult = new StringBuilder();
            if (!string.IsNullOrEmpty(name))
                nameResult.Append(char.ToUpper(name[0]) + name.Substring(1));
            Console.Write("Введите ввозраст: ");
            string age = Console.ReadLine();
            Console.Write("Введите город: ");
            string city = Console.ReadLine();
            StringBuilder cityResult = new StringBuilder();
            if (!string.IsNullOrEmpty(city))
                cityResult.Append(char.ToUpper(city[0]) + city.Substring(1));
            StringBuilder result = new StringBuilder();
            result.Append("Имя: ").Append(nameResult).Append(", Возраст: ").Append(age).Append(", Город: ").Append(cityResult);
            Console.WriteLine("Результат:");
            Console.WriteLine(result.ToString());
            Console.ReadKey();
        }
    }
}
