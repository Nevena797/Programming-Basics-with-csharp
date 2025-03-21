string name = Console.ReadLine();

int graduatedForm = 0;
int failureCount = 0;
double gradesSum = 0;

while (graduatedForm < 12 && failureCount < 2)
{
    double currentGrade = double.Parse(Console.ReadLine());
    if (currentGrade >= 4)
    {
        graduatedForm++;
        gradesSum += currentGrade;
    }
    else
    {
        failureCount++;
    }
}
if (graduatedForm == 12)
{
    Console.WriteLine($"{name} graduated. Average grade: {gradesSum / graduatedForm:f2}");
}
else
{
    Console.WriteLine($"{name} has been excluded at {graduatedForm +1} grade");
}
