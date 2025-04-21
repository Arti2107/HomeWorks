namespace Task7_4
{
    internal class Program
    {
        static void Main()
        {
            int array1 = FindMax(5, 8, 15, 4, 11);
            Console.WriteLine($"Максимальный элемент первого массива: {array1}");

            int array2 = FindMax(-10, 0, 2, -5, 6);
            Console.WriteLine($"Максимальный элемент второго массива: {array2}");
            Console.ReadKey();
        } 
        static int FindMax(params int[] numbers)
        {
            int max = 0;
            foreach (int number in numbers)
                if (number > max)
                {
                    max = number;
                }
            return max;
        }
    }
}
