namespace Homework;

class Magazine : LibraryItem
{
    public int IssueNumber { get; set; }
    public DateTime PublicationDate { get; set; }

    public Magazine(string itemID, string title, int issueNumber, DateTime publicationDate, int availableCopies)
    {
        ItemID = itemID;
        Title = title;
        IssueNumber = issueNumber;
        PublicationDate = publicationDate;
        AvailableCopies = availableCopies;
    }

    public override void DisplayInfo() 
        => Console.WriteLine($"Magazine ID: {ItemID}\nTitle: {Title}\nIssue Number: {IssueNumber}\nPublication Date: {PublicationDate.ToShortDateString()}\nAvailable Copies: {AvailableCopies}");

}
