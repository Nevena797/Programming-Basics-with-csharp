int number = int.Parse(Console.ReadLine());


int row = 1;
int col = 1;

for (int i = 1; i <= number; i++)
{
    Console.Write($"{i} ");

    if (row == col)
    {
        row++;
        col = 1;
        Console.WriteLine();
    }
    else
    {
        col++;
    }
}
