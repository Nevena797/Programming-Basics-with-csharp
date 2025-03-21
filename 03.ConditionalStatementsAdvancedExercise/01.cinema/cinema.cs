string projection = Console.ReadLine();
int row = int.Parse(Console.ReadLine());
int column = int.Parse(Console.ReadLine());
double pricePremiere = 12.00;
double priceNormal = 7.50;
double priceDiscount = 5.00;
double income = 0.0;

if (projection == "Premiere")
{
    income = row * column * pricePremiere;
}
else if (projection == "Normal")
{
    income = row * column * priceNormal;
}
else if (projection == "Discount")
{
    income = row * column * priceDiscount;
}

Console.WriteLine($"{income:F2} leva");
