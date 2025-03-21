string userName = Console.ReadLine();
string password = Console.ReadLine();

string currentIanput = Console.ReadLine();

while (currentIanput != password)
{
    currentIanput = Console.ReadLine();
}
Console.WriteLine($"Welcome {userName}!");