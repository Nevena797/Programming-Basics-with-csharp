int n = int.Parse(Console.ReadLine());

int maxNumber = int.MinValue;

int sumOfNumbers = 0;

for (int i = 0; i < n; i++)
{
    int currentNumber = int.Parse(Console.ReadLine());
    sumOfNumbers += currentNumber;

    if (currentNumber > maxNumber)
    {
        maxNumber = currentNumber; 
    }
}
int sumOfNumbersWithoutMax = sumOfNumbers - maxNumber;

if (sumOfNumbersWithoutMax == maxNumber)
{
    Console.WriteLine($"Yes\r\nSum = {maxNumber}");
}
else
{
    int difference = Math.Abs(sumOfNumbersWithoutMax - maxNumber);
    Console.WriteLine($"No\r\nDiff = {difference}");
}