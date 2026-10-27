class Book:AbstractBook,Borrowable
{
    public void Borrow()
    {
        Console.WriteLine("Book borrowed");
    }
    public void ReturnBook()
    {
        Console.WriteLine("Book returned");
    }
}