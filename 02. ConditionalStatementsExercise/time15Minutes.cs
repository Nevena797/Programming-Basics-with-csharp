int hour = int.Parse(Console.ReadLine());
int minutes = int.Parse(Console.ReadLine());

int futureMinutes = minutes + 15;
if (futureMinutes >= 60)
{
    hour += 1;
    futureMinutes = futureMinutes - 60;
}

if (hour >= 24)
{
    hour -= 24;
}
if (futureMinutes < 10)
{
    Console.WriteLine($"{hour}:0{futureMinutes}");
}
else
{
    Console.WriteLine($"{hour}:{futureMinutes}");
}