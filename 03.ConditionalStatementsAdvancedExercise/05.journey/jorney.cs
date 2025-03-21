
double budget = double.Parse(Console.ReadLine());
string season = Console.ReadLine();
string holidayPlace = "";
string destination = "";
double price = 0;

if (budget <= 100)
{
    destination = "Bulgaria";
    if (season == "summer")
    {
        holidayPlace = "Camp";
        price = budget * 0.30;
    }
    else if (season == "winter")
    {
        holidayPlace = "Hotel";
        price = budget * 0.70;
    }
}
else if (budget <= 1000)
{
    destination = "Balkans";
    if (season == "summer")
    {
        holidayPlace = "Camp";
        price = budget * 0.40;
    }
    else if (season == "winter")
    {
        holidayPlace = "Hotel";
        price = budget * 0.80;
    }
}
else
{
    destination = "Europe";
    holidayPlace = "Hotel";
    price = budget * 0.90;
}

Console.WriteLine($"Somewhere in {destination}");
Console.WriteLine($"{holidayPlace} - {price:F2}");
