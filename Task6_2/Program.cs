namespace Task6_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите предложение (без знаков препинания):");
            string input = Console.ReadLine();
            static bool IsPalindrome(string input)
            {
                string cleaned = input.Replace(" ", "").ToLower();
                for (int i = 0; i < cleaned.Length / 2; i++)
                {
                    if (cleaned[i] != cleaned[cleaned.Length - 1 - i])
                    {
                        return false;
                    }
                }
                return true;
            }
            if (IsPalindrome(input))
            {
                Console.WriteLine("Это палиндром!");
            }
            else
            {
                Console.WriteLine("Это не палиндром :(");
            }
            Console.ReadKey();
        }
    }
}