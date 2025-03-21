using System.Text.Unicode;

int degrees = int.Parse(Console.ReadLine());
string dayPart = Console.ReadLine();
string outfit = "";
string shoes = "";

if (dayPart == "Morning")
{
    if (10<=degrees  && degrees <= 18)
    {
        outfit = "Sweatshirt";
    shoes = "Sneakers";
    }
    else if (degrees <= 24)
    {
        outfit = "Shirt";
        shoes = "Moccasins";
    }
    else if (degrees >= 25)
    {
        outfit = "T-Shirt";
        shoes = "Sandals";
    }
}
else if (dayPart == "Afternoon")
{
    if (10 <= degrees && degrees <= 18)
    {
        outfit = "Shirt";
        shoes = "Moccasins";
    }
    else if (degrees <= 24)
    {
        outfit = "T-Shirt";
        shoes = "Sandals";
    }
    else if (degrees >= 25)
    {
        outfit = "Swim Suit";
        shoes = "Barefoot";
    }
}
else if (dayPart == "Evening")
{
    if (10 <= degrees && degrees <= 18)
    {
        outfit = "Shirt";
        shoes = "Moccasins";
    }
    else if (degrees <= 24)
    {
        outfit = "Shirt";
        shoes = "Moccasins";
    }
    else if (degrees >= 25)
    {
        outfit = "Shirt";
        shoes = "Moccasins";
    }
}
Console.WriteLine($"It's {degrees} degrees, get your {outfit} and {shoes}.");