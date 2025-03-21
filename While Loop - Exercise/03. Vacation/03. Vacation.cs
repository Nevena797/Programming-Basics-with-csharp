double neededMoney = double.Parse(Console.ReadLine());
double ownedMoney = double.Parse(Console.ReadLine());

int daysCounter = 0;
int spendingCounter = 0;

while (ownedMoney < neededMoney && spendingCounter < 5)
{
    string command = Console.ReadLine();
    double money = double.Parse(Console.ReadLine());
    daysCounter++;

    if (command == "spend")
    {
        if (ownedMoney < 0)
        {
            ownedMoney = 0;
            break;
        }
        else
        {
            ownedMoney -= money;
            spendingCounter++;
        }
    }
    else if (command == "save")
    {
        ownedMoney += money;
        spendingCounter=0;
    }
}
if (spendingCounter == 5)
{
    Console.WriteLine("You can't save the money.");
    Console.WriteLine(daysCounter);
}
if (ownedMoney >= neededMoney)
{
    Console.WriteLine($"You saved the money for {daysCounter} days.");
}