namespace CS_Library;

class Program
{
    static void Main(string[] args)
    {
        Library library = new Library();
        while(true)
        {
            Console.WriteLine("--------------------------------");
            Console.WriteLine("Library Manager !");
            Console.WriteLine("--------------------------------");
            Console.WriteLine("1. Add a book");
            Console.WriteLine("2. Remove a book");
            Console.WriteLine("3. Search for a book");
            Console.WriteLine("4. View a book in the library");
            Console.WriteLine("5. Exit");
            
            int option;
            while(!int.TryParse(Console.ReadLine(), out option) || option < 1 || option > 5)
            {
                Console.WriteLine("Invalid option. Please try again.");
            }
            switch(option)
            {
                case 1:
                    Console.WriteLine("Enter book name:");
                    string name = Console.ReadLine();
                    Console.WriteLine("Enter book author:");
                    string author = Console.ReadLine();
                    Console.WriteLine("Enter book price:");
                    double price;
                    while(!double.TryParse(Console.ReadLine(), out price) || price <= 0)
                    {
                        Console.WriteLine("Invalid price. Please enter a positive number.");
                    }
                    Console.WriteLine("Enter book quantity:");
                    int quantity;
                    while(!int.TryParse(Console.ReadLine(), out quantity) || quantity < 0)
                    {
                        Console.WriteLine("Invalid quantity. Please enter a non-negative number.");
                    }
                    Book book = new Book(name, author, price, quantity);
                    library.AddBook(book);
                    break;
                case 2:
                    Console.WriteLine("Enter book name:");
                    string bookName = Console.ReadLine();
                    library.RemoveBook(bookName);
                    break;
                case 3:
                    Console.WriteLine("Enter book name:");
                    string bookNameSearch = Console.ReadLine();
                    library.SearchForBook(bookNameSearch);
                    break;
                case 4:
                    library.viewLibrary();
                    break;
                case 5:
                    Environment.Exit(0);
                    break;
            }
        }
    }
}
