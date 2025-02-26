namespace Task3_10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());
            int n1;
            if (n % 100 < 15)
            {
                n1 = n % 100;
            }
            else
            {
                n1 = n % 10;
            }
            switch (n1)
            {
                case 0:
                case 5:
                case 6:
                case 7:
                case 8:
                case 9:
                case 10:
                case 11:
                case 12:
                case 13:
                case 14:
                    Console.WriteLine("Мы построили {0} домов", n);
                    break;
                case 1:
                    Console.WriteLine("Мы построили {0} дом", n);
                    break;
                case 2:
                case 3:
                case 4:
                    Console.WriteLine("Мы построили {0} дома", n);
                    break;
                default:
                    Console.WriteLine("Ошибка! Введите положительное число");
                    break;
            }
            Console.ReadKey();
        }
    }
}
