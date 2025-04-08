namespace Task7_3
{
    internal class Program
    {
        static void Main()
        {
            int[] numbers = { 1, 2, 3, 4, 5 };
            Console.WriteLine("Массив без reverse");
            PrintNumbers(numbers);
            Console.WriteLine();
            Console.WriteLine("Массив c reverse");
            PrintNumbers(numbers, true);
            Console.WriteLine();
            Console.ReadKey();
        }
        static void PrintNumbers(int[] array, bool reverse = false)
        {
            if (reverse == true)
            {
                for (int i = array.Length - 1; i >= 0; i--)
                    Console.Write($"{array[i]} ");
            }
            else
            {
                foreach (int element in array)
                    Console.Write($"{element} ");
            }
        }
    }
}