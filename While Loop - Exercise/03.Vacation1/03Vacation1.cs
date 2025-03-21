double excursionPrice = double.Parse(Console.ReadLine());
double availableMoney = double.Parse(Console.ReadLine());

int consecutiveDaysSpent = 0; 
int totalDays = 0;           
bool isMoneySaved = true;    


while (availableMoney < excursionPrice)
{
    string action = Console.ReadLine(); 
    double money = double.Parse(Console.ReadLine());
    totalDays++; 

    if (action == "save")
    {
        availableMoney += money; 
        consecutiveDaysSpent = 0;
    }
    else if (action == "spend")
    {
        availableMoney -= money;
        if (availableMoney < 0) availableMoney = 0; 

        consecutiveDaysSpent++; 

        if (consecutiveDaysSpent == 5)
        {
            isMoneySaved = false; 
            break;
        }
    }
}


if (isMoneySaved)
{
    Console.WriteLine($"You saved the money for {totalDays} days.");
}
else
{
    Console.WriteLine("You can't save the money.");
    Console.WriteLine(totalDays);
}

