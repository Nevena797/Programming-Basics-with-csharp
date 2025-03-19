double budget = double.Parse(Console.ReadLine());
int extras = int.Parse(Console.ReadLine());
double pricePerOutfit = double.Parse(Console.ReadLine());

double decor = budget * 0.10;
double outfitPrice = extras * pricePerOutfit;


if (extras > 150)
{
    outfitPrice = outfitPrice - (outfitPrice * 0.10);  
}

double totalPrice = outfitPrice + decor;

double moneyDifference = Math.Abs(totalPrice - budget);

if (budget < totalPrice)
{
    Console.WriteLine("Not enough money!");
    Console.WriteLine($"Wingard needs {moneyDifference:f2} leva more.");
}
else
{
    Console.WriteLine("Action!");
    Console.WriteLine($"Wingard starts filming with {moneyDifference:f2} leva left.");
}