const int stepsGoal = 10000;
int totalSteps = 0;
string input = "";

while ((input = Console.ReadLine()) != "Going home")
{
    int steps = int.Parse(input);
    totalSteps += steps;

    if (totalSteps >= stepsGoal)
    {
        Console.WriteLine("Goal reached! Good job!");
        Console.WriteLine($"{totalSteps - stepsGoal} steps over the goal!");
        return;
    }
}

int stepsToHome = int.Parse(Console.ReadLine());
totalSteps += stepsToHome;

if (totalSteps >= stepsGoal)
{
    Console.WriteLine("Goal reached! Good job!");
    Console.WriteLine($"{totalSteps - stepsGoal} steps over the goal!");
}
else
{
    Console.WriteLine($"{stepsGoal - totalSteps} more steps to reach goal.");
}
