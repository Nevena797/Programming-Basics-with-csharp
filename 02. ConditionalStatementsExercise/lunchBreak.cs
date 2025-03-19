string serial = Console.ReadLine();
int durationEpisode = int.Parse(Console.ReadLine());
int durationBreak = int.Parse(Console.ReadLine());

double lunch = durationBreak * 0.125; // double lunch = durationBreak * (1.0/8);
double pause = durationBreak * 0.25; // double lunch = durationBreak * (1.0/4);

double timeLeft = durationBreak - (lunch + pause);

double difference = Math.Abs(timeLeft-durationEpisode);

if (timeLeft >= durationEpisode)
{
    Console.WriteLine($"You have enough time to watch {serial} and left with {Math.Ceiling(difference)} minutes free time.");
}
else
{
    Console.WriteLine($"You don't have enough time to watch {serial}, you need {Math.Ceiling(difference)} more minutes.");
}
