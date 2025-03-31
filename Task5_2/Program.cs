namespace Task5_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const int n = 10;
            int[] array = new int[n];
            int a = 0; // положительные
            int b = 0; // отрицательные
            int c = 0; // равные нулю
            Random rnd = new Random();
            for (int i = 0; i < n; i++)
            {
                array[i] = rnd.Next(-20, 21);
                Console.Write("{0} ", array[i]);
                if (array[i] == 0)
                {
                    c += 1;
                }
                else
                {
                    if (array[i] > 0)
                    {
                        a += 1;
                    }
                    else
                    {
                        b += 1;
                    }
                }
            }
            Console.WriteLine();
            Console.WriteLine("Количество положительных чисел: {0}, количество отрицательных чисел: {1}", a, b);
            Console.WriteLine("Количество чисел, равных нулю: {0}", c);
            Console.ReadKey();
        }
    }
}