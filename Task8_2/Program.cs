namespace Task8_2
{
    internal class Program
    {
        static void Main()
        {
            Console.Write("Введите возраст: ");
            try
            {
                int age = Convert.ToInt32(Console.ReadLine());
                ValidateAge(age);
                Console.WriteLine($"Проверка произведена. Возраст \"{age}\" хороший!");
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine($"Ошибка! {ex.Message}");
            }
            catch (FormatException)
            {
                Console.WriteLine("Ошибка! Введено не число");
            }
            Console.ReadKey();
        }

        static void ValidateAge(int age)
        {
            if (age < 0)
                throw new ArgumentException("Возраст не может быть отрицательным");
            if (age > 150)
                throw new ArgumentException("Слишком большой возраст");
        }
    }
}
