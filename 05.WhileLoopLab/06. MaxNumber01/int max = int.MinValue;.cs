int max = int.MinValue;

for (string input = Console.ReadLine(); input != "Stop"; input = Console.ReadLine())
{
    int currentNumber = int.Parse(input);
    if (currentNumber > max) { max = currentNumber;}
}
Console.WriteLine(max);