using Homework;

Library library = new Library();

library.AddItem(new Book("B001", "C# Basic", "Long Tran", "Programming", 5));
library.AddItem(new Book("B002", "C# Advanced", "Duc Long", "Programming", 3));
library.AddItem(new Magazine("M001", "Tech1", 1, new DateTime(2024, 12, 28), 10));
library.AddItem(new Magazine("M002", "Tech2", 3, new DateTime(2024, 12, 29), 2));

Console.WriteLine("All Library Items:\n");
library.DisplayAllItems();


Console.WriteLine("\nBorrowing a book:\n");
var book1 = (Book)library.Items[0];
book1.BorrowItem();

Console.WriteLine("\nBorrowing a magazine:\n");
var magazine1 = (Magazine)library.Items[2];
magazine1.BorrowItem();

Console.WriteLine("\nReturning a book:\n");
book1.ReturnItem();

Console.WriteLine("\nFiltering magazines by publication year (2024):\n");
library.FilterItemsByYear(2024);
