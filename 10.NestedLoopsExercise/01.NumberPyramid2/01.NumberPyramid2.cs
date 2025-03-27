int n = int.Parse(Console.ReadLine());

bool isValidNumber = true;
int number = 1;

for (int row = 1; row <= n; row++)
{
    for(int col = 1; col <= row; col++)
    {
        Console.Write($"{number++} ");

        if (number > n)
        {
            isValidNumber = false;
            break;
        }
    }

    if (!isValidNumber)
    {
        break;
    }
    Console.WriteLine();
}
