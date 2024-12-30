namespace Homework;

abstract class LibraryItem
{
    public string ItemID { get; set; }
    public string Title { get; set; }
    public int AvailableCopies { get; set; }
    public abstract void DisplayInfo();

    public virtual void BorrowItem()
    {
        if (AvailableCopies > 0)
        {
            AvailableCopies--;
            Console.WriteLine($"You have successfully borrowed '{Title}'. Available copies: {AvailableCopies}");
        }
        else
        {
            Console.WriteLine($"No available copies of '{Title}' to borrow.");
        }
    }

    public virtual void ReturnItem()
    {
        AvailableCopies++;
        Console.WriteLine($"You have successfully returned '{Title}'. Available copies: {AvailableCopies}");
    }
}
