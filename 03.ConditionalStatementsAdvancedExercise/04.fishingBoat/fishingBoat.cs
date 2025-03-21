int budget = int.Parse(Console.ReadLine());
string season = Console.ReadLine();
int numberFishermans = int.Parse(Console.ReadLine());

double priceShip = 0;
double discount = 0;


if (season == "Spring")
{
    priceShip = 3000;
}
else if (season == "Summer" || season == "Autumn")
{
    priceShip = 4200;
}
else if (season == "Winter")
{
    priceShip = 2600;
}


if (numberFishermans <= 6)
{
    discount = 0.10;
}
else if (numberFishermans <= 11)
{
    discount = 0.15;
}
else if (numberFishermans >= 12)
{
    discount = 0.25;
}


double totalPrice = priceShip - (priceShip * discount);


if (numberFishermans % 2 == 0 && season != "Autumn")
{
    totalPrice *= 0.95;
}


double difference = budget - totalPrice;
if (difference >= 0)
{
    Console.WriteLine($"Yes! You have {difference:F2} leva left.");
}
else
{
    Console.WriteLine($"Not enough money! You need {Math.Abs(difference):F2} leva.");
}






