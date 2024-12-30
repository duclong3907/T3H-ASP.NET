namespace Homework;

internal class Library
{
    public List<LibraryItem> Items { get; private set; }
    public Library()
    {
        Items = new List<LibraryItem>();
    }

    public void AddItem(LibraryItem item)
    {
        Items.Add(item);
    }

    public void DisplayAllItems()
    {
        foreach (var item in Items)
        {
            item.DisplayInfo();
            Console.WriteLine();
        }
    }

    public void FilterItemsByYear(int year)
    {
        foreach (var item in Items)
        {
            if (item is Magazine magazine && magazine.PublicationDate.Year == year)
            {
                magazine.DisplayInfo();
                Console.WriteLine();
            }
        }
    }

}
