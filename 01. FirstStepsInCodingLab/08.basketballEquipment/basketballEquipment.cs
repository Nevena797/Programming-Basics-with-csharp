int priceTrenings = int.Parse(Console.ReadLine());

double priceSneekers = priceTrenings * 0.60;
double priceOutfit = priceSneekers * 0.80;
double priceBall = priceOutfit * 0.25;
double priceAccesoaries = priceBall * 0.20;

double totalCosts = priceTrenings + priceSneekers + priceOutfit + priceBall + priceAccesoaries;
Console.WriteLine(totalCosts);

