namespace code_signal;

public class LibrarySystem
{
    public List<Book> Books = new List<Book>();
    public List<User> Users = new List<User>();

    public void AddBook(string title, string author, string publicationYear)
    {
        var book = new Book(title, author, publicationYear);
        Books.Add(book);
    }

    public void AddUser(string id, string name)
    {
        var user = new User(id, name);
        Users.Add(user);
    }

    public void ListBooksAvaiable()
    {
        Console.WriteLine("Avaiable books: ");
        Books.ForEach(b =>
        {
            if (b.Avaiability == true)
                Console.WriteLine(b.Title);
        });
    }

    public void Borrow(string title, string userId)
    {
        var user = Users.FirstOrDefault(u => u.Id == userId);
        var book = Books.FirstOrDefault(b => b.Title == title && b.Avaiability == true);

        if (book != null && user != null)
        {
            user.Borrowed.Add(book);
            book.SetAvaiability(false);
            Console.WriteLine("Book borrowed");
        }

        Console.WriteLine("Book or user isnt avaiable");
    }

    public void ReturnBook(string title, string userId)
    {
        var user = Users.FirstOrDefault(u => u.Id == userId);
        var book = Books.FirstOrDefault(b => b.Title == title && b.Avaiability == false);

        if (book != null && user != null)
        {
            user.Borrowed.Remove(book);
            book.SetAvaiability(true);
            Console.WriteLine("Book returned");
        }
    }

    public class Book
    {
        public string Title { get; private set; }
        public string Author { get; private set; }
        public string PublicationYear { get; private set; }
        public bool Avaiability { get; private set; }

        public Book(string title, string author, string publicationYear)
        {
            this.Title = title;
            this.Author = author;
            this.PublicationYear = publicationYear;
            this.Avaiability = true;
        }

        public void SetAvaiability(bool avaiable)
        {
            this.Avaiability = avaiable;
        }
    }

    public class User
    {
        public string Id { get; private set; }
        public string Name { get; private set; }
        public List<Book> Borrowed { get; private set; } = new List<Book>();

        public User(string id, string name)
        {
            Id = id;
            Name = name;
        }
    }
}
