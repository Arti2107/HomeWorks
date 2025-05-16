namespace Task9_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Book book = new Book("Отцы и дети", "И.С.Тургенев", 2025, 1);
            book.Year = 1862;
            book.Pages = 288;
            Console.WriteLine(book.GetInfo());
            Console.ReadKey();
        }
    }
    public class Book
    {
        private string _title;
        private string _author;
        public int Year { get; set; }
        public int Pages { get; set; }
        public Book(string title, string author, int year, int pages)
        {
            _title = title;
            _author = author;
            Year = year;
            Pages = pages;
        }
        public string GetInfo()
        {
            return $"{_title}, {_author}, {Year} г., {Pages} стр.";
        }

    }

}
