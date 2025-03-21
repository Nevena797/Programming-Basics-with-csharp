int width = int.Parse(Console.ReadLine());
int lenght = int.Parse(Console.ReadLine());

int cakeSize = width * lenght;
int totalPicesTaken = 0;
string input = "";

while ((input =Console.ReadLine()) !="STOP")
{
    int peacesOfCake = int.Parse(input);
    totalPicesTaken += peacesOfCake;

    if (totalPicesTaken > cakeSize)
    {
        Console.WriteLine($"No more cake left! You need {totalPicesTaken - cakeSize} pieces more.");
        return;
    }
}
Console.WriteLine($"{cakeSize - totalPicesTaken} pieces are left.");