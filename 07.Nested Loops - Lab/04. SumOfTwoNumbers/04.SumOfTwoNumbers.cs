int start = int.Parse(Console.ReadLine());
int end = int.Parse(Console.ReadLine());
int magicNumber = int.Parse(Console.ReadLine());

int n = 0;
bool isFound = false;
for (int i = start; i <= end; i++)
{
    for (int j = start; j <= end; j++)
    {
        n++;
        if (i + j == magicNumber)
        {
            Console.WriteLine($"Combination N:{n} ({i} + {j} = {magicNumber})");
            isFound = true;
            break;
        }

    }
    if (isFound) { break; }
}
if (!isFound)
{
    Console.WriteLine($"{n} combinations - neither equals {magicNumber}"); 
}
