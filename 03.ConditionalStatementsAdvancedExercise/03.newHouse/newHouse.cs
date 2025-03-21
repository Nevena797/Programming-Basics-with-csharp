string flower = Console.ReadLine();
int numberOfFlowers = int.Parse(Console.ReadLine());
int budget = int.Parse(Console.ReadLine());
double rosesPrice = 5.00;
double dahliasPrice = 3.80;
double tulipsPrice = 2.80;
double narcissusPrice = 3.00;
double gladiolusPrice = 2.50;
double totalPrice = 0;

if (flower == "Roses")
{
    if (numberOfFlowers > 80)
    {
        totalPrice = numberOfFlowers * rosesPrice * 0.90;
    }
    else
    {
        totalPrice = numberOfFlowers * rosesPrice;
    }
}
else if (flower == "Dahlias")
{
    if (numberOfFlowers > 90)
    {
        totalPrice = numberOfFlowers * dahliasPrice * 0.85;
    }
    else
    {
        totalPrice = numberOfFlowers * dahliasPrice;
    }
}
else if (flower == "Tulips")
{
    if (numberOfFlowers > 80)
    {
        totalPrice = numberOfFlowers * tulipsPrice * 0.85;
    }
    else
    {
        totalPrice = numberOfFlowers * tulipsPrice;
    }
}
else if (flower == "Narcissus")
{
    if (numberOfFlowers < 120)
    {
        totalPrice = numberOfFlowers * narcissusPrice * 1.15;
    }
    else
    {
        totalPrice = numberOfFlowers * narcissusPrice;
    }
}
else if (flower == "Gladiolus")
{
    if (numberOfFlowers < 80)
    {
        totalPrice = numberOfFlowers * gladiolusPrice * 1.20;
    }
    else
    {
        totalPrice = numberOfFlowers * gladiolusPrice;
    }
}

double difference = Math.Abs(budget - totalPrice);
if (budget >= totalPrice)
{
    Console.WriteLine($"Hey, you have a great garden with {numberOfFlowers} {flower} and {difference:f2} leva left.");
}
else
{
    Console.WriteLine($"Not enough money, you need {difference:f2} leva more.");
}
 

