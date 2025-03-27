namespace Task5_8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const int n = 5;
            int[] array = new int[n];
            Random rnd = new Random();
            for (int i = 0; i < n; i++)
            {
                array[i] = rnd.Next(0, 11);
                Console.Write("{0} ", array[i]);
            }
            Console.WriteLine();
            for (int i = 0; i < n - 1; i++)
            {
                for (int j = i + 1; j < n; j++)
                {
                    if (array[i] < array[j])
                    {
                        int t = array[i];
                        array[i] = array[j];
                        array[j] = t;
                    }
                }
            }
            int max = array[0];
            for (int i = 0; i < n; i++)
            {
                if (array[i] > max)
                {
                    max = array[i];
                }
            }
            Console.WriteLine("Наибольший элемент массива: {0}", array[0]);
            Console.WriteLine("На втором месте элемент: {0}", array[1]);
            Console.ReadKey();
        }
    }
}
