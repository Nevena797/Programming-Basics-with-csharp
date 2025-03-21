string flowers = Console.ReadLine();
int count = int.Parse(Console.ReadLine());
int budget = int.Parse(Console.ReadLine());
double finalSum = 0;

switch(flowers)
{
    case "Roses":
        finalSum = count * 5;
        if (count > 80)
        {
            finalSum *= 0.9;
        }
        break;
    case "Dahlias":
        finalSum = count * 3.80;
        if (count > 90)
        {
            finalSum *= 0.85;
        }
        break;
    case "Tulips":
        finalSum = count * 2.80;
        if (count > 80)
        {
            finalSum *= 0.85;
        }
        break;
    case "Narcissus":
        finalSum = count * 3.00;
        if (count < 120)
        {
            finalSum *= 1.15;
        }
        break;
    case "Gladiolus":
        finalSum = count * 2.50;
        if (count < 80)
        {
            finalSum *= 1.20;
        }
        break;
}
if (budget >= finalSum)
{
    Console.WriteLine($"Hey, you have a great garden with {count} {flowers} and {budget - finalSum:f2} leva left.");
}
else 
{
    Console.WriteLine($"Not enough money, you need {finalSum-budget:f2} leva more.");
}


