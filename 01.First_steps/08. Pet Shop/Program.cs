int packegesDog = int.Parse(Console.ReadLine());
int packegesCat = int.Parse(Console.ReadLine());

double dogFoodPrice = 2.5;
double catFoodPrice = 4;

double totalpricefoodDog = dogFoodPrice * packegesDog;
double totalpricefoodCat = catFoodPrice * packegesCat;

double totalprice = totalpricefoodDog + totalpricefoodCat;
Console.WriteLine($"{totalprice} lv.");