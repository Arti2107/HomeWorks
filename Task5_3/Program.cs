namespace Task5_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const int n = 10;
            int[] array = new int[n];
            Random rnd = new Random();
            for (int i = 0; i < n; i++)
            {
                array[i] = rnd.Next(0, 51);
                Console.Write("{0} ", array[i]);
            }
            Console.WriteLine();
            int max = array[0];
            int maxI = 0;
            for (int i = 0; i < n; i++)
            {
                if (array[i] > max)
                {
                    max = array[i];
                    maxI = i;
                }                  
            }
            Console.WriteLine("Максимальный элемент {0} с индексом {1} (прим.: первый элемент массива имеет индекс 0)", max, maxI);
            int min = array[0];
            int minI = 0;
            for (int i = 0; i < n; i++)
            {
                if (array[i] < min)
                {
                    min = array[i];
                    minI = i;
                }
            }
            Console.WriteLine("Минимальный элемент {0} с индексом {1} (прим.: первый элемент массива имеет индекс 0)", min, minI);
            Console.ReadKey();
        }
    }
}