namespace Task9_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                BankAccount account1 = new BankAccount();
                Console.WriteLine($"Счет N-{account1.AccountNumber}. Остаток на счете: {account1.Balance} р.");
                Console.WriteLine("Пополнение на 1200 рублей");
                account1.Deposit(1200);
                Console.WriteLine($"Остаток на счете: {account1.Balance} р.");
                Console.WriteLine("Снятие 700 рублей");
                account1.Withdraw(700);
                Console.WriteLine($"Остаток на счете: {account1.Balance} р.");
                Console.WriteLine("Снятие 100 рублей");
                account1.Withdraw(100);
                Console.WriteLine($"Остаток на счете: {account1.Balance} р.");
                Console.WriteLine();

                BankAccount account2 = new BankAccount();
                Console.WriteLine($"Счет N-{account2.AccountNumber}. Остаток на счете: {account2.Balance} р.");
                Console.WriteLine("Пополнение на 300 рублей");
                account2.Deposit(300);
                Console.WriteLine($"Остаток на счете: {account2.Balance} р.");
                Console.WriteLine("Снятие 500 рублей");
                account2.Withdraw(500);
                Console.WriteLine($"Остаток на счете: {account2.Balance} р.");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Ошибка: {ex.Message}");
            }
            Console.WriteLine();
            Console.WriteLine($"Всего счетов: {BankAccount.TotalAccounts}");
            Console.ReadKey();
        }
    }
    public class BankAccount
    {
        private decimal _balance;
        private static int _totalAccounts = 0;
        public int AccountNumber { get; }
        public decimal Balance
        {
            get { return _balance; }
            private set { _balance = value; }
        }
        public static int TotalAccounts
        {
            get { return _totalAccounts; }
        }
        public BankAccount()
        {
            _totalAccounts++;
            Random rnd = new Random();
            AccountNumber = rnd.Next(1000, 10000);
            _balance = 0;
        }
        public void Deposit(decimal amount)
        {
            if (amount <= 0)
                throw new ArgumentException("Сумма пополнения должна быть положительной");
            Balance += amount;
        }
        public void Withdraw(decimal amount)
        {
            if (amount <= 0)
                throw new ArgumentException("Сумма списания должна быть положительной");

            if (amount > Balance)
                throw new InvalidOperationException("Недостаточно средств на счете");
            Balance -= amount;
        }
    }
}
