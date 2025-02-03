using System.Numerics;

double chickenMenue = 10.35;
double fishMenue = 12.40;
double vegiMenue = 8.15;
double priceDelivery = 2.50;

int numberChickenMenues = int.Parse(Console.ReadLine());
int numberFishMenues = int.Parse(Console.ReadLine());
int numberVegiMenues = int.Parse(Console.ReadLine());

double priceChichenMenues = chickenMenue * numberChickenMenues;
double priceFishMenue = fishMenue * numberFishMenues;
double priceVegiMenue = vegiMenue * numberVegiMenues;
double priceMenues = priceChichenMenues + priceFishMenue + priceVegiMenue;
double priceDesert = priceMenues * 0.20;
double totalSum = priceMenues + priceDesert + priceDelivery;
Console.WriteLine(totalSum);