namespace DelegatePredicateHomework
{
    public class BookService
    {

        public delegate bool CheckBook(Book book);

        public void ShowBook(List<Book> books, CheckBook check)
        {
            int count = 0;

            foreach (var book in books)
            {
                if (check(book))
                {
                    count++;
                }

            }

            Console.WriteLine(count);

        }

        public void ShowBookResult()
        {
            List<Book> books = new()
            {
                new Book {Id = 1, Author = "Nizami" , Name = "Yeddi gozel" },
                new Book {Id = 2, Author = "Malcolm" , Name = "Outliers" },
            };

            ShowBook(books, book => book.Author == "Nizami");
        }
    }
}
