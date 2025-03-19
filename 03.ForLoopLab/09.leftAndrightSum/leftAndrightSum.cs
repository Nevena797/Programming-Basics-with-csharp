int n = int.Parse(Console.ReadLine());
int rightSum = 0;
int leftSum = 0;

for (int i = 0; i < n * 2; i++)
{
    int currentNumber = int.Parse(Console.ReadLine());
    if (i < n)
    {
        leftSum += currentNumber; 
    }
    else
    {
        rightSum += currentNumber; 
    }
}

if (rightSum == leftSum)
{
    Console.WriteLine($"Yes, sum = {rightSum}");
}
else
{
    int difference = Math.Abs(rightSum - leftSum);
    Console.WriteLine($"No, diff = {difference}");
}



