string destination = Console.ReadLine();
while (destination != "End")
{
    double requirdAmount = double.Parse(Console.ReadLine());

    double savedMoney = 0;
    while (savedMoney < requirdAmount)
    {
        double currentAmount = double.Parse(Console.ReadLine());
        savedMoney += currentAmount;
    }
    Console.WriteLine($"Going to {destination}!");

    destination = Console.ReadLine();
}