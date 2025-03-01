namespace Task3_6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = Convert.ToInt32(Console.ReadLine());
            if (a % 2 == 0)
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