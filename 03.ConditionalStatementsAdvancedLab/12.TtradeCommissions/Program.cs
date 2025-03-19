string city = Console.ReadLine();
double salesVolume = double.Parse(Console.ReadLine());

double percentageCommission = 0;

if (city == "Sofia")
{
    if (salesVolume > 10000) { percentageCommission = 0.12; }
    else if (salesVolume > 1000) { percentageCommission = 0.08; }
    else if (salesVolume > 500) { percentageCommission = 0.07; }
    else if (salesVolume >= 0) { percentageCommission = 0.05; }
}
else if (city == "Varna")
{
    if (salesVolume > 10000) { percentageCommission = 0.13; }
    else if (salesVolume > 1000) { percentageCommission = 0.10; }
    else if (salesVolume > 500) { percentageCommission = 0.075; }
    else if (salesVolume >= 0) { percentageCommission = 0.045; }
}
else if (city == "Plovdiv")
{
    if (salesVolume > 10000) { percentageCommission = 0.145; }
    else if (salesVolume > 1000) { percentageCommission = 0.12; }
    else if (salesVolume > 500) { percentageCommission = 0.08; }
    else if (salesVolume >= 0) { percentageCommission = 0.055; }
}

if (percentageCommission == 0)
{
    Console.WriteLine("error");
}
else
{
    double profit = salesVolume * percentageCommission;
    Console.WriteLine($"{profit:f2}");
}