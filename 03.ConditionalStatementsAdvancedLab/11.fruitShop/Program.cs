﻿using System;

string fruit = Console.ReadLine().ToLower();
string dayOfWeek = Console.ReadLine().ToLower();
double quantity = double.Parse(Console.ReadLine());
double fruitPrice = 0.0;
switch (dayOfWeek)
{
    case "monday":
    case "tuesday":
    case "wednesday":
    case "thursday":
    case "friday":
        switch (fruit)
        {
            case "banana":
                fruitPrice = 2.50;
                break;
            case "apple":
                fruitPrice = 1.20;
                break;
            case "orange":
                fruitPrice = 0.85;
                break;
            case "grapefruit":
                fruitPrice = 1.45;
                break;
            case "kiwi":
                fruitPrice = 2.70;
                break;
            case "pineapple":
                fruitPrice = 5.50;
                break;
            case "grapes":
                fruitPrice = 3.85;
                break;
            default:
                Console.WriteLine("error");
                break;
        }

        break;
    case "saturday":
    case "sunday":
        switch (fruit)
        {
            case "banana":
                fruitPrice = 2.70;
                break;
            case "apple":
                fruitPrice = 1.25;
                break;
            case "orange":
                fruitPrice = 0.90;
                break;
            case "grapefruit":
                fruitPrice = 1.60;
                break;
            case "kiwi":
                fruitPrice = 3.00;
                break;
            case "pineapple":
                fruitPrice = 5.60;
                break;
            case "grapes":
                fruitPrice = 4.20;
                break;
            default:
                Console.WriteLine("error");
                break;
        }

        break;
    default:
        Console.WriteLine("error");
        break;
}

if (fruitPrice != 0)
{
    Console.WriteLine($"{quantity * fruitPrice:f2}");
}

