using System.Text.RegularExpressions;

namespace Task6_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string phoneNumber;
            Regex regex = new Regex (@"^\+7\([0-9]{3}\)[0-9]{3}-[0-9]{2}-[0-9]{2}$");
            bool f;
            do
            {
                Console.Write("Введите номер телефона в формате +7(XXX)XXX-XX-XX: ");
                phoneNumber = Console.ReadLine();
                f = regex.IsMatch(phoneNumber);
                if (!f)
                {
                    Console.WriteLine("Некорректный формат номера. Попробуйте снова.");
                }
            } 
            while (!f);
            Console.WriteLine("Номер введен корректно: {0}", phoneNumber);
            Console.ReadKey();
        }
    }
}
