int totalSteps = 0;
string input = "";

while ((input= Console.ReadLine()) != "Going home")
{
    int steps = int.Parse(input);
    totalSteps += steps;
    if (totalSteps >= 10000)
    {
        break;
    }
}
if (totalSteps < 10000)
{
    int stepsToHome = int.Parse(Console.ReadLine());
    totalSteps += stepsToHome;
}
int difference = Math.Abs(totalSteps - 10000);
if (totalSteps >= 10000)
{
    Console.WriteLine("Goal reached! Good job!");
    Console.WriteLine($"{difference} steps over the goal!");
}
else
{
    Console.WriteLine($"{difference} more steps to reach goal.");
}