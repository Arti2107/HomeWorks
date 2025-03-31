using System.Text.RegularExpressions;

namespace Task6_6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Требования к паролю:\n-Длина от 14 символов;\n-Минимум одна цифра;\n-Минимум одна заглавная буква;\n-Минимум одна строчная буква\n-Минимум один специальный символ из набора !#;%:?*");
            string password;
            Regex regex = new Regex(@"^(?=.*[0-9])(?=.*[a-zа-яё])(?=.*[A-ZА-ЯЁ])(?=.*[!#;%:?*]).{14,}$");
            bool f;
            do
            {
                Console.Write("Введите пароль: ");
                password = Console.ReadLine();
                f = regex.IsMatch(password);
                if (!f)
                {
                    Console.WriteLine("Некорректный пароль. Попробуйте снова.");
                }
            }
            while (!f);
            Console.WriteLine("Корректный пароль: {0}", password);
            Console.ReadKey();
        }
    }
}