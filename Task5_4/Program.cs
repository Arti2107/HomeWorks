namespace Task5_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const int n = 10;
            int[] array = new int[n];
            Console.Write("Исходный массив: ");
            Random rnd = new Random();
            for (int i = 0; i < n; i++)
            {
                array[i] = rnd.Next(0, 11);
                Console.Write("{0} ", array[i]);
            }
            Console.WriteLine();
            Console.Write("Преобразованный массив: ");
            for (int i = 0; i < n - 5; i++)
            {
                int t = array[i];
                array[i] = array[9 - i];
                array[9 - i] = t;
            }
            for (int i = 0; i < n; i++)
            {
                Console.Write("{0} ", array[i]);
            }
            Console.ReadKey();
        }
    }
}