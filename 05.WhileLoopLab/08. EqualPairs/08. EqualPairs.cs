int n = int.Parse(Console.ReadLine());

int previousPairSum = 0;
int maxDiff = 0;

for (int i = 0; i < n; i++)
{
    int first = int.Parse(Console.ReadLine());
    int second= int.Parse(Console.ReadLine());

    int currentPairSum = first + second;

    if (i > 0)
    {
        maxDiff = Math.Max(maxDiff, Math.Abs(currentPairSum-previousPairSum));
    }
    previousPairSum = currentPairSum;
}

if (maxDiff == 0)
{
    Console.WriteLine($"Yes, value={previousPairSum}");
}
else
{
    Console.WriteLine($"No, maxdiff={maxDiff}");
}