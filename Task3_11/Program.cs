namespace Task3_11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = Convert.ToInt32(Console.ReadLine());
            int b = Convert.ToInt32(Console.ReadLine());
            int p = Convert.ToInt32(Console.ReadLine());
            int q = Convert.ToInt32(Console.ReadLine());
            int r = Convert.ToInt32(Console.ReadLine());
            int s = Convert.ToInt32(Console.ReadLine());
            if (((a - p >= r) || (a - p >= s)) && ((a - q >= r) || (a - q >= s)) && ((b - p >= r) || (b - p >= s)) && ((b - q >= r) || (b - q >= s)))
            {
                Console.WriteLine("Дома помещаются на участок");
            }
            else
            {
                Console.WriteLine("Дома не помещаются на участок");
            }
            Console.ReadKey();
        }
    }
}
