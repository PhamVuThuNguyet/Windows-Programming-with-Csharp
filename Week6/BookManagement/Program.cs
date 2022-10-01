using System.Collections;

namespace BookManagement
{
    interface IBook
    {
        public string Title { get; set; }
        public string Author { get; set; }
        public string Publisher { get; set; }
        public int PublishYear { get; set; }
        public string ISBN { get; set; }
        public List<string> Chapters { get; set; }

        public void Show();
    }

    class SortByAuthHelper : IComparer<Book>
    {
        public int Compare(Book? x, Book? y)
        {
            return x.Author.CompareTo(y.Author);
        }
    }

    class SortByYearHelper : IComparer<Book>
    {
        public int Compare(Book x, Book y)
        {
            return x.PublishYear.CompareTo(y.PublishYear);
        }
    }

    class Book : IBook, IComparable<Book>
    {
        #region Attributes

        private string _title;
        private string _author;
        private string _publisher;
        private string _iSBN;

        private List<string> _chapters = new List<string>();

        #endregion

        public string Title
        {
            get => _title;
            set => _title = value ?? throw new ArgumentNullException(nameof(value));
        }

        public string Author
        {
            get => _author;
            set => _author = value ?? throw new ArgumentNullException(nameof(value));
        }

        public string Publisher
        {
            get => _publisher;
            set => _publisher = value ?? throw new ArgumentNullException(nameof(value));
        }

        public int PublishYear { get; set; }

        public string ISBN
        {
            get => _iSBN;
            set => _iSBN = value ?? throw new ArgumentNullException(nameof(value));
        }

        public List<string> Chapters
        {
            get => _chapters;
            set => _chapters = value ?? throw new ArgumentNullException(nameof(value));
        }

        public void Show()
        {
            Console.WriteLine(
                $"Title: {Title}, Author: {Author}, Publisher: {Publisher}, Year: {PublishYear}, ISBN: {ISBN}");
            foreach (var chapter in Chapters)
            {
                Console.WriteLine(chapter);
            }

            Console.WriteLine("======================================");
        }

        public void Input()
        {
            Console.Write("Enter title: ");
            Title = Console.ReadLine();

            Console.Write("Enter author: ");
            Author = Console.ReadLine();

            Console.Write("Enter publisher: ");
            Publisher = Console.ReadLine();

            Console.Write("Enter publish year: ");
            PublishYear = int.Parse(Console.ReadLine());

            Console.Write("Enter isbn: ");
            ISBN = Console.ReadLine();

            Console.Write("Enter number of chapters: ");
            var NoChap = int.Parse(Console.ReadLine());

            for (int i = 0; i < NoChap; i++)
            {
                Console.Write($"Enter chapter {i}: ");
                Chapters.Add(Console.ReadLine());
            }
        }


        public int CompareTo(Book? other)
        {
            return Title.CompareTo(other.Title);
        }
    }

    class BookList
    {
        private List<Book> _books = new List<Book>();

        public List<Book> Books
        {
            get => _books;
            set => _books = value ?? throw new ArgumentNullException(nameof(value));
        }

        public void AddBook()
        {
            Book book = new Book();
            book.Input();
            Books.Add(book);
        }

        public void ShowList()
        {
            foreach (var book in Books)
            {
                book.Show();
            }
        }

        public void InputList()
        {
            Console.Write("Enter number of books: ");
            var NoBook = int.Parse(Console.ReadLine());

            for (int i = 0; i < NoBook; i++)
            {
                AddBook();
            }
        }

        public void Sort()
        {
            Books.Sort();
        }

        public void SortByAuth()
        {
            Books.Sort(new SortByAuthHelper());
        }

        public void SortByYear()
        {
            Books.Sort(new SortByYearHelper());
        }
    }

    internal class MainProgram
    {
        public static void Main(string[] args)
        {
            BookList bookList = new BookList();
            bookList.InputList();

            Console.WriteLine("=========================================");

            Console.WriteLine("Sort by title: ");
            bookList.Sort();
            bookList.ShowList();

            Console.WriteLine("=========================================");

            Console.WriteLine("Sort by author: ");
            bookList.SortByAuth();
            bookList.ShowList();

            Console.WriteLine("=========================================");

            Console.WriteLine("Sort by year: ");
            bookList.SortByYear();
            bookList.ShowList();
        }
    }
}