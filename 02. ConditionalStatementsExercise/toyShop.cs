double pricePuzzle = 2.60;
double priceDoll = 3;
double priceBears = 4.10;
double priceMinion = 8.20;
double priceTruck = 2;


double priceVacantion = double.Parse(Console.ReadLine());
int puzzles = int.Parse(Console.ReadLine());
int dolls = int.Parse(Console.ReadLine());
int bears = int.Parse(Console.ReadLine());
int minions = int.Parse(Console.ReadLine());
int trucks = int.Parse(Console.ReadLine());


double sumeToys = puzzles * pricePuzzle + dolls * priceDoll + bears * priceBears + minions * priceMinion + trucks * priceTruck;
int countToys = puzzles + dolls + bears + minions + trucks;

if (countToys >= 50)
{
    sumeToys = sumeToys - (sumeToys * 0.25); //sumeToys ==sumeToys * 0.75  
}
double rent = sumeToys * 0.1;

sumeToys = sumeToys - rent;

double restMoney = priceVacantion - sumeToys;

if (sumeToys >= priceVacantion)
{
    Console.WriteLine($"Yes! {Math.Abs(restMoney):F2} lv left.");
}
else
{
    Console.WriteLine($"Not enough money! {Math.Abs(restMoney):F2} lv needed.");
}




