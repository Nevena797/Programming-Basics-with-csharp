﻿using System.ComponentModel.Design;

int hour = int.Parse(Console.ReadLine());
string day = Console.ReadLine();
if (hour >= 10 && hour <= 18 && day != "Sunday")
{
    Console.WriteLine("open");
}
else
    Console.WriteLine("closed");