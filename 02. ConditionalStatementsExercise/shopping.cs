int graphicCardPrice = 250;  


double budget = double.Parse(Console.ReadLine());
int graphicsCards = int.Parse(Console.ReadLine());
int procesors = int.Parse(Console.ReadLine());
int ram = int.Parse(Console.ReadLine());


double graphicsCardsPrice = graphicCardPrice * graphicsCards;
double procesorsPrice = procesors * (graphicsCardsPrice * 0.35); 
double ramPrice = ram * (graphicsCardsPrice * 0.10); 
double totalSum = graphicsCardsPrice + procesorsPrice + ramPrice; 


if (graphicsCards > procesors)
{
    totalSum = totalSum - (totalSum * 0.15); 
}


double difference = Math.Abs(budget - totalSum);


if (budget >= totalSum)
{
    Console.WriteLine($"You have {difference:f2} leva left!"); 
}
else
{
    Console.WriteLine($"Not enough money! You need {difference:f2} leva more!"); 
}
