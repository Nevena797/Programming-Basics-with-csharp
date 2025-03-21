int floars = int.Parse(Console.ReadLine());
int rooms = int.Parse(Console.ReadLine());

for (int i = floars; i > 0 ; i--)
{
    string roomType;
    if (i == floars)
    {
        roomType = "L";
    }
    else if (i % 2 == 0) 
    {
        roomType = "O";
    }
    else {
        roomType = "A";
    }

    for (int j = 0; j < rooms; j++)
    { 
        if (j > 0) { Console.Write(" "); }
        Console.Write($"{roomType}{i}{j}");
    }
    Console.WriteLine();
}