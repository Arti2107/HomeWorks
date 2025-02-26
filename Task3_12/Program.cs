namespace Task3_12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = Convert.ToInt32(Console.ReadLine());
            if (a >= 100 && a <= 999)
            {
                int a100 = a / 100;
                int a10 = a / 10 % 10;
                int a1 = a % 10;
                switch (a100)
                {
                    case 1:
                        Console.Write("сто ");
                        break;
                    case 2:
                        Console.Write("двести ");
                        break;
                    case 3:
                        Console.Write("триста ");
                        break;
                    case 4:
                        Console.Write("четыреста ");
                        break;
                    case 5:
                        Console.Write("пятьсот ");
                        break;
                    case 6:
                        Console.Write("шестьсот ");
                        break;
                    case 7:
                        Console.Write("семьсот ");
                        break;
                    case 8:
                        Console.Write("восемьсот ");
                        break;
                    case 9:
                        Console.Write("девятьсот ");
                        break;
                    default:
                        Console.Write(" Ошибка! ");
                        break;
                }
                if (a % 100 <= 19)
                {
                    switch (a % 100)
                    {
                        case 1:
                            Console.Write("один");
                            break;
                        case 2:
                            Console.Write("два");
                            break;
                        case 3:
                            Console.Write("три");
                            break;
                        case 4:
                            Console.Write("четыре");
                            break;
                        case 5:
                            Console.Write("пять");
                            break;
                        case 6:
                            Console.Write("шесть");
                            break;
                        case 7:
                            Console.Write("семь");
                            break;
                        case 8:
                            Console.Write("восемь");
                            break;
                        case 9:
                            Console.Write("девять");
                            break;
                        case 10:
                            Console.Write("десять");
                            break;
                        case 11:
                            Console.Write("одиннадцать");
                            break;
                        case 12:
                            Console.Write("двенадцать");
                            break;
                        case 13:
                            Console.Write("тринадцать");
                            break;
                        case 14:
                            Console.Write("четырнадцать");
                            break;
                        case 15:
                            Console.Write("пятнадцать");
                            break;
                        case 16:
                            Console.Write("шестнадцать");
                            break;
                        case 17:
                            Console.Write("семнадцать");
                            break;
                        case 18:
                            Console.Write("восемнадцать");
                            break;
                        case 19:
                            Console.Write("девятнадцать");
                            break;
                        default:
                            Console.Write(":-)");
                            break;
                    }
                }
                else
                {
                    switch (a10)
                    {
                        case 2:
                            Console.Write("двадцать ");
                            break;
                        case 3:
                            Console.Write("тридцать ");
                            break;
                        case 4:
                            Console.Write("сорок ");
                            break;
                        case 5:
                            Console.Write("пятьдесят ");
                            break;
                        case 6:
                            Console.Write("шестьдесят ");
                            break;
                        case 7:
                            Console.Write("семьдесят ");
                            break;
                        case 8:
                            Console.Write("восемьдесят ");
                            break;
                        case 9:
                            Console.Write("девяносто ");
                            break;
                        default:
                            Console.Write(" Ошибка! ");
                            break;
                    }
                    switch (a1)
                    {
                        case 1:
                            Console.Write("один ");
                            break;
                        case 2:
                            Console.Write("два");
                            break;
                        case 3:
                            Console.Write("три");
                            break;
                        case 4:
                            Console.Write("четыре");
                            break;
                        case 5:
                            Console.Write("пять");
                            break;
                        case 6:
                            Console.Write("шесть");
                            break;
                        case 7:
                            Console.Write("семь");
                            break;
                        case 8:
                            Console.Write("восемь");
                            break;
                        case 9:
                            Console.Write("девять");
                            break;
                        default:
                            Console.Write(" Ошибка! ");
                            break;
                    }
                }
            }
            else
            {
                Console.Write("Ошибка! Введите трехзначное число");
            }
            Console.ReadKey();
        }
    }
}
