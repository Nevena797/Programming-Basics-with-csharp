using System;

class StepsTracker
{
    static void Main()
    {
        const int dailyGoal = 10000;
        int totalSteps = 0;

        while (totalSteps < dailyGoal)
        {
            string input = Console.ReadLine();

            if (input == "Going home")
            {
                int stepsToHome = int.Parse(Console.ReadLine());
                totalSteps += stepsToHome;
                break;
            }
            else
            {
                int steps = int.Parse(input);
                totalSteps += steps;
            }
        }

        if (totalSteps >= dailyGoal)
        {
            Console.WriteLine("Goal reached! Good job!");
            Console.WriteLine($"{totalSteps - dailyGoal} steps over the goal!");
        }
        else
        {
            Console.WriteLine($"{dailyGoal - totalSteps} more steps to reach goal.");
        }
    }
}