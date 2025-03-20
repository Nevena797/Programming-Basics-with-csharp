int tournaments = int.Parse(Console.ReadLine());
int initialPoints = int.Parse(Console.ReadLine());

int pointsForCurrentSeason = 0;
int tournamentsWon = 0;

for (int i = 0; i < tournaments; i++)
{
    string result = Console.ReadLine();

    if (result == "W")
    {
        pointsForCurrentSeason += 2000;
        tournamentsWon++;
    }
    else if (result == "F")
    {
        pointsForCurrentSeason += 1200;

    }
    else if (result == "SF")
    {
        pointsForCurrentSeason += 720;
    }

}


int finalPoints = initialPoints + pointsForCurrentSeason;
int averagePoints = pointsForCurrentSeason / tournaments;
double persentageTournamentsWon = 100.0 * tournamentsWon / tournaments;

Console.WriteLine($"Final points: {finalPoints}");
Console.WriteLine($"Average points: {averagePoints}");
Console.WriteLine($"{persentageTournamentsWon:f2}%");