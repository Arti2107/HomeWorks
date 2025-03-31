namespace Task5_6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const int n = 5;
            int[,] array = new int[n, n];
            for (int i = 0; i < n; i++)
            {
                if (i % 2 == 0)
                {
                    for (int j = 0; j < n; j++)
                    {
                        array[i, j] = j % 2 != 1 ? 1 : 0;
                        Console.Write("{0} ", array[i, j]);
                    }
                }
                else
                {
                    for (int j = 0; j < n; j++)
                    {
                        array[i, j] = j % 2 == 1 ? 1 : 0;
                        Console.Write("{0} ", array[i, j]);
                    }
                }
                Console.WriteLine();
            }
            Console.ReadKey();
        }
    }
}