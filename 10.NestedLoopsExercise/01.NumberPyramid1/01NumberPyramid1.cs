int n = int.Parse(Console.ReadLine());

int number = 1;
for (int row = 1; row <= n; row++)
{
    for (int col = 1; col <= row; col++)
    {
        Console.Write($"{number++} ");

        if (number > n)
        {
            return;
        }
    }
    Console.WriteLine();
}