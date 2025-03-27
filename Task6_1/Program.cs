namespace Task6_1
{
    internal class Program
    {
        static void Main()
        {
            Console.Write("Введите предложение: ");
            string input = Console.ReadLine();
            string[] words = input.Split(' ');
            string longestWord = "";
            int maxLength = 0;
            foreach (string word in words)
            {
                if (word.Length > maxLength)
                {
                    maxLength = word.Length;
                    longestWord = word;
                }
            }
            Console.WriteLine("Самое длинное слово: {0}", longestWord);
            Console.ReadKey();
        }
    }
}