string bookToFind = Console.ReadLine();
int booksCount = 0;

while (true)
{
    string book = Console.ReadLine();

    if (book == "No More Books")
    {
        Console.WriteLine($"The book you search is not here!");
        Console.WriteLine($"You checked {booksCount} books.");
        break;
    }

    if (book == bookToFind)
    {
        Console.WriteLine($"You checked {booksCount} books and found it.");
        break;
    }

    booksCount++;
}