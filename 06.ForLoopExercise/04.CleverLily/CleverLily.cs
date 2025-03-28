﻿int age = int.Parse(Console.ReadLine());
double washingMachinePrice = double.Parse(Console.ReadLine());
int toyPrice = int.Parse(Console.ReadLine());

int savedMoney = 0;
int giftedMoney = 10;
for (int i = 1; i <= age; i++)
{
    if (i % 2 != 0)
    {
        savedMoney += toyPrice;
    }
    else 
    {
        savedMoney += giftedMoney - 1;
        giftedMoney += 10;
    }
}

double difference = Math.Abs(savedMoney - washingMachinePrice);
string formatedDiff = difference.ToString(format: "f2");
if (savedMoney >= washingMachinePrice)
{
    Console.WriteLine($"Yes! {formatedDiff}");
}
else 
{
    Console.WriteLine($"No! {formatedDiff}");
}