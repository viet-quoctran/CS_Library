namespace CS_Library;
class Book
{
    public string Title { get; set; }
    public string Author { get; set; }
    private double price;
    public double Price
    {
        get => price;
        set
        {
            if(value < 0) throw new ArgumentException("Book price must be positive");
            price = value;
        }
    }
    private int quantity;
    public int Quantity
    {
        get => quantity;
        set
        {
            if(value <= 0) throw new ArgumentException("Book quantity must be positive");
            quantity = value;
        }
    }
    public Book(string title, string author, double price, int quantity)
    {
        Title = title;
        Author = author;
        Price = price;
        Quantity = quantity;
    }
}