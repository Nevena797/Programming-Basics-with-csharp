int startPoints = int.Parse(Console.ReadLine());
double bonus = 0.0;

if (startPoints <= 100)
{
    bonus = 5;
}
else if (startPoints <= 1000)
{
    bonus = (double)startPoints * 0.2;
}
else
{
    bonus = startPoints * 0.1;
}
if (startPoints % 2 == 0)
{
    bonus += 1;
}
else if (startPoints % 10 == 5)
{
    bonus += 2;
}
Console.WriteLine(bonus);
Console.WriteLine(startPoints + bonus);