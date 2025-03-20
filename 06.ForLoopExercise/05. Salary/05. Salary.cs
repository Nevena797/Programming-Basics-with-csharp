int numberTabs = int.Parse(Console.ReadLine());
int salary = int.Parse(Console.ReadLine());

int fine = 0;

for (int i = 0; i < numberTabs && fine<salary; i++)
{
    string tabName = Console.ReadLine();

    if (tabName == "Facebook") 
    {
        fine += 150;
    }
    else if (tabName == "Instagram")
    {
        fine += 100;
    }
    else if (tabName == "Reddit")
    {
        fine += 50;
    }
}
if (fine>=salary)
{
    Console.WriteLine($"You have lost your salary.");
}
else
{
    Console.WriteLine($"{salary - fine}");
}