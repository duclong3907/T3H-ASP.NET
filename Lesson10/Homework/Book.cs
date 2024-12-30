namespace Homework;

class Book : LibraryItem
{
    public string Author { get; set; }
    public string Genre { get; set; }

    public Book(string itemID, string title, string author, string genre, int availableCopies)
    {
        ItemID = itemID;
        Title = title;
        Author = author;
        Genre = genre;
        AvailableCopies = availableCopies;
    }

    public override void DisplayInfo() => Console.WriteLine($"Book ID: {ItemID}\nTitle: {Title}\nAuthor: {Author}\nGenre: {Genre}\nAvailable Copies: {AvailableCopies}");

}
