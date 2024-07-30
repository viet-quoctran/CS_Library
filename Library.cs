using System.ComponentModel.DataAnnotations;

namespace CS_Library;
class Library
{
    public List<Book> Items { get; private set; }
    public Library()
    {
        Items = new List<Book>();
    }
    public void AddBook(Book book)
    {
        Items.Add(book);
        Console.WriteLine("Book " + book.Title + " successfully added");
    }
    public void RemoveBook(string bookName)
    {
        var book = Items.Find(item => item.Title.Equals(bookName, StringComparison.OrdinalIgnoreCase));
        if(book != null)
        {
            Items.Remove(book);
            Console.WriteLine("Book " + bookName + " successfully removed");
        }
        else
        {
            Console.WriteLine($"Could not find book{bookName} in library");
        }
    }
    public void viewLibrary()
    {
        if(Items.Count == 0)
        {
            Console.WriteLine("Library is empty");
            return;
        }
        Console.WriteLine("Library have" + Items.Count + " books");
        foreach( var item in Items )
        {
            Console.WriteLine("Book : " + item.Title + "Author : " + item.Author + "Price : " + item.Price + "Quantity : " + item.Quantity);   
        }
        
    }
    public void SearchForBook(string name){
        var book = Items.Find(item => item.Title.Equals(name, StringComparison.OrdinalIgnoreCase));
        if(book!= null)
        {
            Console.WriteLine("Book Found : " + book.Title + "Author : " + book.Author + "Price : " + book.Price + "Quantity : " + book.Quantity);
        }
    }
}